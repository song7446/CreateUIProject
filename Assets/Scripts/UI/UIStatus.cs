using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIStatus : MonoBehaviour
{
    [SerializeField] Button backButton;
    [SerializeField] Transform slotsParent;
    [SerializeField] List<Sprite> icons;
    [SerializeField] GameObject slotPrefab;
    RectTransform statusRectTransform;

    private void Awake()
    {
        backButton.onClick.AddListener(OnClickBackButton);
        statusRectTransform = GetComponent<RectTransform>();
    }

    private void Start()
    {
        CreateSlots();
    }

    void CreateSlots()
    {
        foreach (CharacterStatus status in GameManager.Instance.Player.playerStatus)
        {     
            UIStatusSlot slot = Instantiate(slotPrefab, slotsParent).GetComponent<UIStatusSlot>();
            slot.SetSlotInfo(icons[SelectIcon(status.statusName)], status.statusName, status.statusNum);
        }
    }

    void OnClickBackButton()
    {
        statusRectTransform.DOAnchorPosX(0, 1f);
    }

    int SelectIcon(string name)
    {
        switch (name)
        {
            case "공격력":
                return 0;
            case "방어력":
                return 1;
            case "체력":
                return 2;
        }
        return -1;
    }
}
