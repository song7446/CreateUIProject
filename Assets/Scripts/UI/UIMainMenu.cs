using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIMainMenu : MonoBehaviour
{
    // �÷��̾� ���� UI
    public UIPlayerInfo uiPlayerInfo;
    // ���� UI �ҷ����� ��ư
    public Button statusButton;
    // �κ��丮 UI �ҷ����� ��ư
    public Button inventoryButton;

    private void Awake()
    {
        // �÷��̾� ���� UI
        uiPlayerInfo = GetComponentInChildren<UIPlayerInfo>();
        // ���� UI ��ư ������ �߰�
        statusButton.onClick.AddListener(OnStatusButtonClicked);
        // �κ��丮 UI ��ư ������ �߰� 
        inventoryButton.onClick.AddListener(OnInventoryButtonClicked);
    }

    // ���� UI �ҷ����� �Լ� 
    public void OnStatusButtonClicked()
    {
        // ���� UI ȭ�� �ۿ��� ������ �����̵�
        GameManager.Instance.UIManager.UIStatus.GetComponent<RectTransform>().DOAnchorPosX(-600, 1f);
    }

    // �κ��丮 UI �ҷ����� �Լ�
    public void OnInventoryButtonClicked()
    {
        // �κ��丮 UI ȭ�� �ۿ��� ������ �����̵�
        GameManager.Instance.UIManager.UIInventory.GetComponent<RectTransform>().DOAnchorPosX(-600, 1f);
    }
}
