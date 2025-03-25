using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIStatus : MonoBehaviour
{
    [SerializeField] Button backButton;
    [SerializeField] Transform slotsParent;
    [SerializeField] List<Sprite> icons;
    [SerializeField] GameObject slotPrefab;
    RectTransform statusRectTransform;
    public List<UIStatusSlot> slots;

    private void Awake()
    {
        backButton.onClick.AddListener(OnClickBackButton);
        statusRectTransform = GetComponent<RectTransform>();

        slots = new List<UIStatusSlot>();
    }

    private void Start()
    {
        CreateSlots();
    }

    void CreateSlots()
    {
        foreach (CharacterStatus status in GameManager.Instance.Player.playerStatus)
        {
            UIStatusSlot slot = Instantiate(slotPrefab, slotsParent).GetComponent<UIStatusSlot>();
            SetSlotInfo(slot, icons[SelectIcon(status.statusType)], status);
            slots.Add(slot);
        }
    }

    void OnClickBackButton()
    {
        statusRectTransform.DOAnchorPosX(0, 1f);
    }

    int SelectIcon(StatusType statusType)
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

    public void SetSlotInfo(UIStatusSlot slot, Sprite sprite, CharacterStatus characterStatus)
    {
        slot.characterStatus = characterStatus;
        slot.statusIconImage.sprite = sprite;
        slot.statusNameText.text = characterStatus.statusName;
        slot.statusNumText.text = characterStatus.statusNum.ToString();
    }

    public void UpdateStatus(Item item)
    {
        foreach (UIStatusSlot slot in slots)
        {
            if (GameManager.Instance.Player.equipItem != null)
            {
                if (slot.characterStatus.statusType == GameManager.Instance.Player.equipItem.item.plusStatus.statusType)
                {
                    slot.statusNumText.text = slot.statusNumText.text.Substring(0, slot.statusNumText.text.IndexOf(' '));
                }
            }
            if (slot.characterStatus.statusType == item.plusStatus.statusType)
            {
                slot.statusNumText.text += " + " + item.plusStatus.statusNum.ToString();
            }
        }
    }
}
