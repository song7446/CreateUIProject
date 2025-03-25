using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum StatusType
{
    None,
    Attack,
    Defense,
    Health,
}


[Serializable]
public class CharacterStatus
{
    public StatusType statusType;
    public string statusName;
    public int statusNum;  
}
