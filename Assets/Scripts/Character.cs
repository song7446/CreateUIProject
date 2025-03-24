using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string playerName { get; private set; }
    public int playerLevel { get; private set; }
    public int playerMaxExp { get; private set; }
    public int playerExp { get; private set; }
    public int playerGold { get; private set; }
    public string playerExpain{ get; private set; }

    private void Awake()
    {
        playerName = "송원석";
        playerLevel = 18;
        playerMaxExp = 20;
        playerExp = 13;
        playerGold = 1345900;
        playerExpain = "코딩의 노예가 된지 10년짜리 되는 머슴입니다. 오늘도 밤샐일만 남아서 치킨을 시킬지도 모른다는 생각에 배민을 키고 있네요.";
    }
}
