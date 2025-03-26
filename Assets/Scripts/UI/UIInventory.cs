using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// 인벤토리
public class UIInventory : MonoBehaviour
{
    // 돌아가기 버튼
    [SerializeField] Button backButton;
    // 인벤토리 트렌스폼
    RectTransform inventoryRectTransform;

    // 인벤토리 아이템 부모 오브젝트
    [SerializeField] Transform slotParent;
    // 인벤토리 아이템 프리펩 
    [SerializeField] GameObject slotPrefab;

    // 아이템 리스트
    List<ItemObject> itemSlots;

    // 아이템 설명 게임 오브젝트
    public GameObject itemText;
    // 아이템 이름
    public TextMeshProUGUI itemName;
    // 아이템 설명
    public TextMeshProUGUI itemDescription;

    private void Awake()
    {
        // 돌아가기 버튼 리스너 추가 
        backButton.onClick.AddListener(OnClickBackButton);
        // 인벤토리 트렌스폼 
        inventoryRectTransform = GetComponent<RectTransform>();
        // 아이템 리스트 초기화
        itemSlots = new List<ItemObject>();
    }

    private void Start()
    {
        // 플레이어 아이템 정보 순회
        foreach(Item item in GameManager.Instance.Player.items)
        {
            // 프리펩 복사
            ItemObject go = Instantiate(slotPrefab, slotParent).GetComponent<ItemObject>();
            // 아이템 데이터 설정 
            go.item = item;
            go.itemIcon.sprite = item.icon;
            // 아이템 리스트에 추가 
            itemSlots.Add(go);
        }
    }

    // 돌아가기 버튼 함수 
    void OnClickBackButton()
    {
        // 인벤토리 UI 화면 안에서 화면 밖으로 슬라이딩
        inventoryRectTransform.DOAnchorPosX(0, 1f);
    }
}
