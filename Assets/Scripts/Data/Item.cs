using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 아이템 데이터 스크립터블 오브젝트

[CreateAssetMenu(fileName = "Item", menuName = "New Item")]
public class Item : ScriptableObject
{
    [Header("ItemInfo")]
    public string displayName;
    public string description;
    public Sprite icon;
    public CharacterStatus plusStatus;
}
