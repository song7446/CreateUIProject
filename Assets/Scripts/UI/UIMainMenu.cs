using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIMainMenu : MonoBehaviour
{
    public UIPlayerInfo uiPlayerInfo;
    public Button statusButton;
    public Button inventoryButton;

    private void Awake()
    {
        uiPlayerInfo = GetComponentInChildren<UIPlayerInfo>();
        statusButton.onClick.AddListener(OnStatusButtonClicked);
        inventoryButton.onClick.AddListener(OnInventoryButtonClicked);
    }

    private void Start()
    {
        uiPlayerInfo.UpdatePlayerInfo();
    }

    public void OnStatusButtonClicked()
    {
        GameManager.Instance.UIManager.UIStatus.GetComponent<RectTransform>().DOAnchorPosX(-600, 1f);
    }

    public void OnInventoryButtonClicked()
    {
        GameManager.Instance.UIManager.UIInventory.GetComponent<RectTransform>().DOAnchorPosX(-600, 1f);
    }
}
