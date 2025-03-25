using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Item", menuName = "New Item")]
public class Item : ScriptableObject
{
    [Header("ItemInfo")]
    public string displayName;
    public string description;
    public Sprite icon;
    public CharacterStatus plusStatus;
}
