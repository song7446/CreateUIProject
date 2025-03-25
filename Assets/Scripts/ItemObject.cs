using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemObject : MonoBehaviour
{
    public Item item;
    public Image equipIcon;
    public Button equipButton;

    private void Awake()
    {
        equipButton = GetComponent<Button>();
        equipButton.onClick.AddListener(EquipItem);
        equipIcon = transform.GetChild(1).GetComponent<Image>();
    }

    void EquipItem()
    {
        equipIcon.gameObject.SetActive(true);
        if (GameManager.Instance.Player.equipItem != null)
            GameManager.Instance.Player.equipItem.equipIcon.gameObject.SetActive(false);
        GameManager.Instance.UIManager.UIStatus.UpdateStatus(item);
        GameManager.Instance.Player.EquipItem(this);
    }
}
