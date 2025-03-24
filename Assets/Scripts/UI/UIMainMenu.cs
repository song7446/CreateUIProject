using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    public UIPlayerInfo uiPlayerInfo;
    public Button statusButton;
    public Button inventoryButton;
    public Button backButton;

    private void Awake()
    {
        uiPlayerInfo = GetComponentInChildren<UIPlayerInfo>();
        statusButton.onClick.AddListener(OnStatusButtonClicked);
        inventoryButton.onClick.AddListener(OnInventoryButtonClicked);
        backButton.onClick.AddListener(OnBackButtonClicked);

    }

    private void Start()
    {
        uiPlayerInfo.UpdatePlayerInfo();
    }

    public void OnStatusButtonClicked()
    {
        GameManager.Instance.UIManager.UIStatus.gameObject.SetActive(true);
        ButtonsChangeActive();
    }

    public void OnInventoryButtonClicked()
    {
        GameManager.Instance.UIManager.UIInventory.gameObject.SetActive(true);
        ButtonsChangeActive();
    }

    public void OnBackButtonClicked()
    {
        statusButton.gameObject.SetActive(true);
        inventoryButton.gameObject.SetActive(true);
        backButton.gameObject.SetActive(false);
        GameManager.Instance.UIManager.UIInventory.gameObject.SetActive(false);
        GameManager.Instance.UIManager.UIStatus.gameObject.SetActive(false);
    }

    public void ButtonsChangeActive()
    {
        statusButton.gameObject.SetActive(false);
        inventoryButton.gameObject.SetActive(false);
        backButton.gameObject.SetActive(true);
    }
}
