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
        playerName = "�ۿ���";
        playerLevel = 18;
        playerMaxExp = 20;
        playerExp = 13;
        playerGold = 1345900;
        playerExpain = "�ڵ��� �뿹�� ���� 10��¥�� �Ǵ� �ӽ��Դϴ�. ���õ� ����ϸ� ���Ƽ� ġŲ�� ��ų���� �𸥴ٴ� ������ ����� Ű�� �ֳ׿�.";
    }
}
