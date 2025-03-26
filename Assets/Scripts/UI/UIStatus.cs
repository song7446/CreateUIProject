using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

// 플레이어 스탯 UI
public class UIStatus : MonoBehaviour
{
    // 돌아가기 버튼
    [SerializeField] private Button backButton;

    // 스탯 부모 트랜스폼
    [SerializeField] private Transform slotsParent;

    // 스탯 아이콘 리스트
    [SerializeField] private List<Sprite> icons;

    // 스탯 프리팹
    [SerializeField] private GameObject slotPrefab;

    // 스탯 트랜스폼
    private RectTransform statusRectTransform;

    // 스탯 리스트
    private List<UIStatusSlot> slots;

    private void Awake()
    {
        // 돌아가기 버튼 리스너 추가 
        backButton.onClick.AddListener(OnClickBackButton);

        // 스탯 트랜스폼 불러오기 
        statusRectTransform = GetComponent<RectTransform>();

        // 스탯 리스트 
        slots = new List<UIStatusSlot>();
    }

    private void Start()
    {
        // 스탯 슬롯들 만들기 
        CreateSlots();
    }

    // 스탯 슬롯들 만들기 함수 
    private void CreateSlots()
    {
        // 플레이어 스탯 정보 순회
        foreach (CharacterStatus status in GameManager.Instance.Player.playerStatus)
        {
            // 스탯 슬롯 프리펩 복사 
            UIStatusSlot slot = Instantiate(slotPrefab, slotsParent).GetComponent<UIStatusSlot>();

            // 스탯 정보에 따라 아이콘 설정 
            SetSlotInfo(slot, icons[SelectIcon(status.statusType)], status);

            // 스탯 슬롯 리스트에 추가 
            slots.Add(slot);
        }
    }

    // 돌아가기 버튼 함수 
    private void OnClickBackButton()
    {
        // 스탯 UI 화면 안에서 밖으로 슬라이딩
        statusRectTransform.DOAnchorPosX(0, 1f);
    }

    // 스탯 아이콘 설정 
    private int SelectIcon(StatusType statusType)
    {
        switch (statusType)
        {
            case StatusType.Attack:
                return 0;
            case StatusType.Defense:
                return 1;
            case StatusType.Health:
                return 2;
        }
        return -1;
    }

    // 슬롯 데이터 설정 
    private void SetSlotInfo(UIStatusSlot slot, Sprite sprite, CharacterStatus characterStatus)
    {
        // 플레이어 스텟 설정
        slot.characterStatus = characterStatus;
        // 스탯 아이콘 설정 
        slot.statusIconImage.sprite = sprite;
        // 스탯 이름 설정
        slot.statusNameText.text = characterStatus.statusName;
        // 스탯 수치 설정 
        slot.statusNumText.text = characterStatus.statusNum.ToString();
    }

    // 아이템 장착시 스탯 업데이트 함수 
    public void UpdateStatus(Item item)
    {
        // 스탯 UI 리스트 순회 
        foreach (UIStatusSlot slot in slots)
        {
            // 원래 장착하고 있던 아이템이 있다면 (착용하고 있는 아이템이 없을 수도 있기 때문에 null 방지)
            if (GameManager.Instance.Player.equipItem != null)
            {
                // 원래 장착하고 있는 아이템과 같은 스탯 찾기
                if (slot.characterStatus.statusType == GameManager.Instance.Player.equipItem.item.plusStatus.statusType)
                {
                    // 해당 스탯 원상 복구 
                    slot.statusNumText.text = slot.statusNumText.text.Substring(0, slot.statusNumText.text.IndexOf(' '));
                }
            }
            // 장착할 아이템이 올려주는 스탯 찾기
            if (slot.characterStatus.statusType == item.plusStatus.statusType)
            {
                // 해당 스탯에 추가 스탯 텍스트 추가
                slot.statusNumText.text += " + " + item.plusStatus.statusNum.ToString();
            }
        }
    }
}
