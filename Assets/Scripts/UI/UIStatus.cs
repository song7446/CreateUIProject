using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIStatus : MonoBehaviour
{
    [SerializeField] Button backButton;
    RectTransform statusRectTransform;

    private void Awake()
    {
        backButton.onClick.AddListener(OnClickBackButton);
        statusRectTransform = GetComponent<RectTransform>();
    }

    void OnClickBackButton()
    {
        statusRectTransform.DOAnchorPosX(0, 1f);
    }
}
