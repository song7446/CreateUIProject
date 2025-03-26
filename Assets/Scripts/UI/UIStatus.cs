using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

// �÷��̾� ���� UI
public class UIStatus : MonoBehaviour
{
    // ���ư��� ��ư
    [SerializeField] private Button backButton;

    // ���� �θ� Ʈ������
    [SerializeField] private Transform slotsParent;

    // ���� ������ ����Ʈ
    [SerializeField] private List<Sprite> icons;

    // ���� ������
    [SerializeField] private GameObject slotPrefab;

    // ���� Ʈ������
    private RectTransform statusRectTransform;

    // ���� ����Ʈ
    private List<UIStatusSlot> slots;

    private void Awake()
    {
        // ���ư��� ��ư ������ �߰� 
        backButton.onClick.AddListener(OnClickBackButton);

        // ���� Ʈ������ �ҷ����� 
        statusRectTransform = GetComponent<RectTransform>();

        // ���� ����Ʈ 
        slots = new List<UIStatusSlot>();
    }

    private void Start()
    {
        // ���� ���Ե� ����� 
        CreateSlots();
    }

    // ���� ���Ե� ����� �Լ� 
    private void CreateSlots()
    {
        // �÷��̾� ���� ���� ��ȸ
        foreach (CharacterStatus status in GameManager.Instance.Player.playerStatus)
        {
            // ���� ���� ������ ���� 
            UIStatusSlot slot = Instantiate(slotPrefab, slotsParent).GetComponent<UIStatusSlot>();

            // ���� ������ ���� ������ ���� 
            SetSlotInfo(slot, icons[SelectIcon(status.statusType)], status);

            // ���� ���� ����Ʈ�� �߰� 
            slots.Add(slot);
        }
    }

    // ���ư��� ��ư �Լ� 
    private void OnClickBackButton()
    {
        // ���� UI ȭ�� �ȿ��� ������ �����̵�
        statusRectTransform.DOAnchorPosX(0, 1f);
    }

    // ���� ������ ���� 
    private int SelectIcon(StatusType statusType)
    {
        switch (statusType)
        {
            case StatusType.Attack:
                return 0;
            case StatusType.Defense:
                return 1;
            case StatusType.Health:
                return 2;
        }
        return -1;
    }

    // ���� ������ ���� 
    private void SetSlotInfo(UIStatusSlot slot, Sprite sprite, CharacterStatus characterStatus)
    {
        // �÷��̾� ���� ����
        slot.characterStatus = characterStatus;
        // ���� ������ ���� 
        slot.statusIconImage.sprite = sprite;
        // ���� �̸� ����
        slot.statusNameText.text = characterStatus.statusName;
        // ���� ��ġ ���� 
        slot.statusNumText.text = characterStatus.statusNum.ToString();
    }

    // ������ ������ ���� ������Ʈ �Լ� 
    public void UpdateStatus(Item item)
    {
        // ���� UI ����Ʈ ��ȸ 
        foreach (UIStatusSlot slot in slots)
        {
            // ���� �����ϰ� �ִ� �������� �ִٸ� (�����ϰ� �ִ� �������� ���� ���� �ֱ� ������ null ����)
            if (GameManager.Instance.Player.equipItem != null)
            {
                // ���� �����ϰ� �ִ� �����۰� ���� ���� ã��
                if (slot.characterStatus.statusType == GameManager.Instance.Player.equipItem.item.plusStatus.statusType)
                {
                    // �ش� ���� ���� ���� 
                    slot.statusNumText.text = slot.statusNumText.text.Substring(0, slot.statusNumText.text.IndexOf(' '));
                }
            }
            // ������ �������� �÷��ִ� ���� ã��
            if (slot.characterStatus.statusType == item.plusStatus.statusType)
            {
                // �ش� ���ȿ� �߰� ���� �ؽ�Ʈ �߰�
                slot.statusNumText.text += " + " + item.plusStatus.statusNum.ToString();
            }
        }
    }
}
