using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatusSlot : MonoBehaviour
{
    [SerializeField] Image statusIconImage;
    public TextMeshProUGUI statusNameText;
    public TextMeshProUGUI statusNumText;
    public CharacterStatus characterStatus;

    public void SetSlotInfo(Sprite sprite, CharacterStatus characterStatus)
    {
        this.characterStatus = characterStatus;
        statusIconImage.sprite = sprite;
        statusNameText.text = characterStatus.statusName;
        statusNumText.text = characterStatus.statusNum.ToString();
    }
}
