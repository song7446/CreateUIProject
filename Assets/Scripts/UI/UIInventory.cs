using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] Button backButton;
    RectTransform inventoryRectTransform;

    [SerializeField] Transform slotParent;
    [SerializeField] GameObject slotPrefab;

    List<ItemObject> itemSlots;

    private void Awake()
    {
        backButton.onClick.AddListener(OnClickBackButton);
        inventoryRectTransform = GetComponent<RectTransform>();
        itemSlots = new List<ItemObject>();
    }

    private void Start()
    {
        foreach(Item item in GameManager.Instance.Player.items)
        {
            ItemObject go = Instantiate(slotPrefab, slotParent).GetComponent<ItemObject>();
            go.item = item;
            go.itemIcon.sprite = item.icon;
            go.itemName.text = item.displayName;
            go.itemDescription.text = item.description;
            itemSlots.Add(go);
        }
    }

    void OnClickBackButton()
    {
        inventoryRectTransform.DOAnchorPosX(0, 1f);
    }
}
