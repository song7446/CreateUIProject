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
        characterInfo.CharacterName = "�ۿ���";
        characterInfo.CharacterLevel = 18;
        characterInfo.CharacterMaxExp = 20;
        characterInfo.CharacterExp = 13;
        characterInfo.CharacterGold = 1345900;
        characterInfo.CharacterExpain = "�ڵ��� �뿹�� ���� 10��¥�� �Ǵ� �ӽ��Դϴ�. ���õ� ����ϸ� ���Ƽ� ġŲ�� ��ų���� �𸥴ٴ� ������ ����� Ű�� �ֳ׿�.";
    }

    void PlayerStatusSet()
    {
        attackStatus.statusName = "���ݷ�";
        attackStatus.statusNum = 35;
        attackStatus.statusType = StatusType.Attack;
        playerStatus.Add(attackStatus);

        defenseStatus.statusName = "����";
        defenseStatus.statusNum = 40;
        defenseStatus.statusType = StatusType.Defense;
        playerStatus.Add(defenseStatus);

        healthStatus.statusName = "ü��";
        healthStatus.statusNum = 100;
        healthStatus.statusType = StatusType.Health;
        playerStatus.Add(healthStatus);
    }

    public void EquipItem(ItemObject item)
    {
        equipItem = item;
    }
}
