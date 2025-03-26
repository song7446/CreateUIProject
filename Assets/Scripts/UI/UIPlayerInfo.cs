using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIPlayerInfo : MonoBehaviour
{
    // �÷��̾� �̸�
    [SerializeField] private TextMeshProUGUI playerName;
    // �÷��̾� ����
    [SerializeField] private TextMeshProUGUI playerLevel;
    // �÷��̾� �ִ� ����ġ
    [SerializeField] private TextMeshProUGUI playerMaxExp;
    // �÷��̾� ���� ����ġ
    [SerializeField] private TextMeshProUGUI playerExp;
    // �÷��̾� ����
    [SerializeField] private TextMeshProUGUI playerExplain;
    // �÷��̾� ����ġ ��
    [SerializeField] private Image playerExpBar;
    // �÷��̾� ���
    [SerializeField] private TextMeshProUGUI gold;

    private void Start()
    {
        // ������ �ҷ�����
        UpdatePlayerInfo();
    }

    private void UpdatePlayerInfo()
    {
        // �̸� ����
        SetName();
        // ���� ����
        SetLevel();
        // ����ġ ����
        SetExp();
        // ���� ����
        SetExplain();
        // ��� ����
        SetGold();
    }

    // �̸� ���� �Լ�
    private void SetName()
    {
        // �÷��̾� �̸��� �ҷ��� �ؽ�Ʈ�� �־��ֱ�
        playerName.text = GameManager.Instance.Player.characterInfo.CharacterName.ToString();
    }

    // ���� ���� �Լ�
    private void SetLevel()
    {
        // �÷��̾� ������ �ҷ��� �ؽ�Ʈ�� �־��ֱ�
        playerLevel.text = GameManager.Instance.Player.characterInfo.CharacterLevel.ToString();
    }

    // ����ġ ���� �Լ�
    private void SetExp()
    {
        // �÷��̾� ���� ����ġ�� �ִ� ����ġ�� ����ġ �� ä���
        playerExpBar.fillAmount = (float)GameManager.Instance.Player.characterInfo.CharacterExp / (float)GameManager.Instance.Player.characterInfo.CharacterMaxExp;
        // �÷��̾� ���� ����ġ�� �ҷ��� �ؽ�Ʈ�� �־��ֱ�
        playerExp.text = GameManager.Instance.Player.characterInfo.CharacterExp.ToString();
        // �÷��̾� �ִ� ����ġ�� �ҷ��� �ؽ�Ʈ�� �־��ֱ�
        playerMaxExp.text = GameManager.Instance.Player.characterInfo.CharacterMaxExp.ToString();
    }

    // ���� ���� �Լ�
    private void SetExplain()
    {
        // �÷��̾� ������ �ҷ��� �ؽ�Ʈ�� �־��ֱ� 
        playerExplain.text = GameManager.Instance.Player.characterInfo.CharacterExpain.ToString();
    }

    // ��� ���� �Լ�
    private void SetGold()
    {
        // �÷��̾� ��带 �ҷ��� õ�� ������ �ĸ� ���
        string playerGold = GameManager.Instance.Player.characterInfo.CharacterGold.ToString("C");
        // ��� �ؽ�Ʈ�� �־��ֱ� 
        gold.text = playerGold.ToString();
    }
}
