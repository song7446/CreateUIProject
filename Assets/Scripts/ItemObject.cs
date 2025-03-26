using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// UI �κ��丮�� �ִ� ������
public class ItemObject : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    // ������ ������
    public Item item;
    // ���� ������ �̹��� 
    public Image equipIcon;
    // ������ �̹��� 
    public Image itemIcon;
    // ���� ��ư
    public Button equipButton; 

    private void Awake()
    {
        // ���� ��ư ������ �߰� 
        equipButton.onClick.AddListener(EquipItem);
    }

    // ������ ���� 
    void EquipItem()
    {
        // �÷��̾ �����ϰ� �ִ� �������� �ִٸ�(�����ϰ� �ִ� �������� ���� ���� �ֱ� ������ null ����)
        if (GameManager.Instance.Player.equipItem != null)
            // �����ϰ� �ִ� �������� ���� ������ �̹��� ��Ȱ��ȭ - ���� �����ϰ� �ִ� ������ ���� ���� 
            GameManager.Instance.Player.equipItem.equipIcon.gameObject.SetActive(false);
        // ���� ������ �������� ���� ������ �̹��� Ȱ��ȭ - ������ ����
        equipIcon.gameObject.SetActive(true);
        // ������ �������� �߰� ���� ������Ʈ 
        GameManager.Instance.UIManager.UIStatus.UpdateStatus(item);
        // �÷��̾� ������ ���� 
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
