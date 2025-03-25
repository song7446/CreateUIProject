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
    public GameObject itemText;
    public TextMeshProUGUI itemName;
    public TextMeshProUGUI itemDescription;

    private void Awake()
    {
        equipButton.onClick.AddListener(EquipItem);
    }
    void EquipItem()
    {
        equipIcon.gameObject.SetActive(true);
        if (GameManager.Instance.Player.equipItem != null)
            GameManager.Instance.Player.equipItem.equipIcon.gameObject.SetActive(false);
        GameManager.Instance.UIManager.UIStatus.UpdateStatus(item);
        GameManager.Instance.Player.EquipItem(this);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        itemText.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        itemText.SetActive(false);
    }
}
