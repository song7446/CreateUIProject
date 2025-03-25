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
        playerName = "�ۿ���";
        playerLevel = 18;
        playerMaxExp = 20;
        playerExp = 13;
        playerGold = 1345900;
        playerExpain = "�ڵ��� �뿹�� ���� 10��¥�� �Ǵ� �ӽ��Դϴ�. ���õ� ����ϸ� ���Ƽ� ġŲ�� ��ų���� �𸥴ٴ� ������ ����� Ű�� �ֳ׿�.";

        playerStatus = new List<CharacterStatus>();

        attackStatus = new CharacterStatus();
        attackStatus.statusName = "���ݷ�";
        attackStatus.statusNum = 35;
        attackStatus.statusType = StatusType.Attack;
        playerStatus.Add(attackStatus);

        defenseStatus = new CharacterStatus();
        defenseStatus.statusName = "����";
        defenseStatus.statusNum = 40;
        defenseStatus.statusType = StatusType.Defense;
        playerStatus.Add(defenseStatus);

        healthStatus = new CharacterStatus();
        healthStatus.statusName = "ü��";
        healthStatus.statusNum = 100;
        healthStatus.statusType = StatusType.Health;
        playerStatus.Add(healthStatus);
    }

    public void SetPlayerStatus(ItemObject item)
    {
        equipItem = item;
    }
}
