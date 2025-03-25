using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemObject : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Item item;
    public Image equipIcon;
    public Image itemIcon;
    public Button equipButton; 

    private void Awake()
    {
        equipButton.onClick.AddListener(EquipItem);
    }
    void EquipItem()
    {
        if (GameManager.Instance.Player.equipItem != null)
            GameManager.Instance.Player.equipItem.equipIcon.gameObject.SetActive(false);
        equipIcon.gameObject.SetActive(true);
        GameManager.Instance.UIManager.UIStatus.UpdateStatus(item);
        GameManager.Instance.Player.EquipItem(this);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        GameManager.Instance.UIManager.UIInventory.itemName.text = item.displayName;
        GameManager.Instance.UIManager.UIInventory.itemDescription.text = item.description;
        GameManager.Instance.UIManager.UIInventory.itemText.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        GameManager.Instance.UIManager.UIInventory.itemText.SetActive(false);
    }
}
