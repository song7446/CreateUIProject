using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatusSlot : MonoBehaviour
{
    [SerializeField] Image statusIconImage;
    [SerializeField] TextMeshProUGUI statusNameText;
    [SerializeField] TextMeshProUGUI statusNumText;


    public void SetSlotInfo(Sprite sprite, string name, int num)
    {
        statusIconImage.sprite = sprite;
        statusNameText.text = name;
        statusNumText.text = num.ToString();
    }
}
