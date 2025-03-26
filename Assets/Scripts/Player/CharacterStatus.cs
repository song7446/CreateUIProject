using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// 스탯 종류
public enum StatusType
{
    None,
    Attack,
    Defense,
    Health,
}

// 스텟 이름 및 수치
[Serializable]
public class CharacterStatus
{
    public StatusType statusType;
    public string statusName;
    public int statusNum;  
}
