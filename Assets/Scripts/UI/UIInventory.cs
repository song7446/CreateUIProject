using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// �κ��丮
public class UIInventory : MonoBehaviour
{
    // ���ư��� ��ư
    [SerializeField] Button backButton;
    // �κ��丮 Ʈ������
    RectTransform inventoryRectTransform;

    // �κ��丮 ������ �θ� ������Ʈ
    [SerializeField] Transform slotParent;
    // �κ��丮 ������ ������ 
    [SerializeField] GameObject slotPrefab;

    // ������ ����Ʈ
    List<ItemObject> itemSlots;

    // ������ ���� ���� ������Ʈ
    public GameObject itemText;
    // ������ �̸�
    public TextMeshProUGUI itemName;
    // ������ ����
    public TextMeshProUGUI itemDescription;

    private void Awake()
    {
        // ���ư��� ��ư ������ �߰� 
        backButton.onClick.AddListener(OnClickBackButton);
        // �κ��丮 Ʈ������ 
        inventoryRectTransform = GetComponent<RectTransform>();
        // ������ ����Ʈ �ʱ�ȭ
        itemSlots = new List<ItemObject>();
    }

    private void Start()
    {
        // �÷��̾� ������ ���� ��ȸ
        foreach(Item item in GameManager.Instance.Player.items)
        {
            // ������ ����
            ItemObject go = Instantiate(slotPrefab, slotParent).GetComponent<ItemObject>();
            // ������ ������ ���� 
            go.item = item;
            go.itemIcon.sprite = item.icon;
            // ������ ����Ʈ�� �߰� 
            itemSlots.Add(go);
        }
    }

    // ���ư��� ��ư �Լ� 
    void OnClickBackButton()
    {
        // �κ��丮 UI ȭ�� �ȿ��� ȭ�� ������ �����̵�
        inventoryRectTransform.DOAnchorPosX(0, 1f);
    }
}
