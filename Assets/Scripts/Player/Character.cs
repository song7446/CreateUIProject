using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string playerName { get; private set; }
    public int playerLevel { get; private set; }
    public int playerMaxExp { get; private set; }
    public int playerExp { get; private set; }
    public int playerGold { get; private set; }
    public string playerExpain { get; private set; }

    public List<CharacterStatus> playerStatus;
    public CharacterStatus attackStatus { get; private set; }
    public CharacterStatus defenseStatus { get; private set; }
    public CharacterStatus healthStatus { get; private set; }

    public List<Item> items;

    public ItemObject equipItem;

    private void Awake()
    {
        SetPlayerData();
    }

    void SetPlayerData()
    {
        playerName = "송원석";
        playerLevel = 18;
        playerMaxExp = 20;
        playerExp = 13;
        playerGold = 1345900;
        playerExpain = "코딩의 노예가 된지 10년짜리 되는 머슴입니다. 오늘도 밤샐일만 남아서 치킨을 시킬지도 모른다는 생각에 배민을 키고 있네요.";

        playerStatus = new List<CharacterStatus>();

        attackStatus = new CharacterStatus();
        attackStatus.statusName = "공격력";
        attackStatus.statusNum = 35;
        attackStatus.statusType = StatusType.Attack;
        playerStatus.Add(attackStatus);

        defenseStatus = new CharacterStatus();
        defenseStatus.statusName = "방어력";
        defenseStatus.statusNum = 40;
        defenseStatus.statusType = StatusType.Defense;
        playerStatus.Add(defenseStatus);

        healthStatus = new CharacterStatus();
        healthStatus.statusName = "체력";
        healthStatus.statusNum = 100;
        healthStatus.statusType = StatusType.Health;
        playerStatus.Add(healthStatus);
    }

    public void SetPlayerStatus(ItemObject item)
    {
        equipItem = item;
    }
}
