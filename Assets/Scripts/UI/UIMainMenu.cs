using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIMainMenu : MonoBehaviour
{
    // 플레이어 정보 UI
    public UIPlayerInfo uiPlayerInfo;
    // 스탯 UI 불러오는 버튼
    public Button statusButton;
    // 인벤토리 UI 불러오는 버튼
    public Button inventoryButton;

    private void Awake()
    {
        // 플레이어 정보 UI
        uiPlayerInfo = GetComponentInChildren<UIPlayerInfo>();
        // 스텟 UI 버튼 리스너 추가
        statusButton.onClick.AddListener(OnStatusButtonClicked);
        // 인벤토리 UI 버튼 리스너 추가 
        inventoryButton.onClick.AddListener(OnInventoryButtonClicked);
    }

    // 스텟 UI 불러오는 함수 
    public void OnStatusButtonClicked()
    {
        // 스텟 UI 화면 밖에서 안으로 슬라이딩
        GameManager.Instance.UIManager.UIStatus.GetComponent<RectTransform>().DOAnchorPosX(-600, 1f);
    }

    // 인벤토리 UI 불러오는 함수
    public void OnInventoryButtonClicked()
    {
        // 인벤토리 UI 화면 밖에서 안으로 슬라이딩
        GameManager.Instance.UIManager.UIInventory.GetComponent<RectTransform>().DOAnchorPosX(-600, 1f);
    }
}
