using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Character : MonoBehaviour
{
    public CharacterInfo characterInfo;

    public List<CharacterStatus> playerStatus;
    public CharacterStatus attackStatus { get; private set; }
    public CharacterStatus defenseStatus { get; private set; }
    public CharacterStatus healthStatus { get; private set; }

    public List<Item> items;

    public ItemObject equipItem;

    private void Awake()
    {
        characterInfo = new CharacterInfo();

        playerStatus = new List<CharacterStatus>();

        attackStatus = new CharacterStatus();
        defenseStatus = new CharacterStatus();
        healthStatus = new CharacterStatus();

        PlayerInfoSet();
        PlayerStatusSet();
    }


    void PlayerInfoSet()
    {
        characterInfo.CharacterName = "송원석";
        characterInfo.CharacterLevel = 18;
        characterInfo.CharacterMaxExp = 20;
        characterInfo.CharacterExp = 13;
        characterInfo.CharacterGold = 1345900;
        characterInfo.CharacterExpain = "코딩의 노예가 된지 10년짜리 되는 머슴입니다. 오늘도 밤샐일만 남아서 치킨을 시킬지도 모른다는 생각에 배민을 키고 있네요.";
    }

    void PlayerStatusSet()
    {
        attackStatus.statusName = "공격력";
        attackStatus.statusNum = 35;
        attackStatus.statusType = StatusType.Attack;
        playerStatus.Add(attackStatus);

        defenseStatus.statusName = "방어력";
        defenseStatus.statusNum = 40;
        defenseStatus.statusType = StatusType.Defense;
        playerStatus.Add(defenseStatus);

        healthStatus.statusName = "체력";
        healthStatus.statusNum = 100;
        healthStatus.statusType = StatusType.Health;
        playerStatus.Add(healthStatus);
    }

    public void EquipItem(ItemObject item)
    {
        equipItem = item;
    }
}
