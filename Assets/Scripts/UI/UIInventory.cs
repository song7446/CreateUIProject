using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] Button backButton;
    RectTransform inventoryRectTransform;

    private void Awake()
    {
        backButton.onClick.AddListener(OnClickBackButton);
        inventoryRectTransform = GetComponent<RectTransform>();
    }

    void OnClickBackButton()
    {
        inventoryRectTransform.DOAnchorPosX(0, 1f);
    }
}
