using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// UI 인벤토리에 있는 아이템
public class ItemObject : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    // 아이템 데이터
    public Item item;
    // 장착 아이콘 이미지 
    public Image equipIcon;
    // 아이템 이미지 
    public Image itemIcon;
    // 장착 버튼
    public Button equipButton; 

    private void Awake()
    {
        // 장착 버튼 리스너 추가 
        equipButton.onClick.AddListener(EquipItem);
    }

    // 아이템 장착 
    void EquipItem()
    {
        // 플레이어가 장착하고 있던 아이템이 있다면(장착하고 있던 아이템이 없을 수도 있기 때문에 null 방지)
        if (GameManager.Instance.Player.equipItem != null)
            // 장착하고 있던 아이템의 장착 아이콘 이미지 비활성화 - 원래 장착하고 있던 아이템 장착 해제 
            GameManager.Instance.Player.equipItem.equipIcon.gameObject.SetActive(false);
        // 현재 장착할 아이템의 장착 아이콘 이미지 활성화 - 아이템 장착
        equipIcon.gameObject.SetActive(true);
        // 장착한 아이템의 추가 스텟 업데이트 
        GameManager.Instance.UIManager.UIStatus.UpdateStatus(item);
        // 플레이어 아이템 장착 
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
