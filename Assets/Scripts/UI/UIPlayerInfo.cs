using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIPlayerInfo : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI playerName;
    [SerializeField] TextMeshProUGUI playerLevel;
    [SerializeField] TextMeshProUGUI playerMaxExp;
    [SerializeField] TextMeshProUGUI playerExp;
    [SerializeField] TextMeshProUGUI playerExplain;
    [SerializeField] Image playerExpBar;
    [SerializeField] TextMeshProUGUI gold;

    public void UpdatePlayerInfo()
    {
        SetName();
        SetLevel();
        SetExp();
        SetExplain();
        SetGold();
    }
    private void SetName()
    {
        playerName.text = GameManager.Instance.Player.characterInfo.CharacterName.ToString();
    }
    private void SetLevel()
    {
        playerLevel.text = GameManager.Instance.Player.characterInfo.CharacterLevel.ToString();
    }
    private void SetExp()
    {
        playerExpBar.fillAmount = (float)GameManager.Instance.Player.characterInfo.CharacterExp / (float)GameManager.Instance.Player.characterInfo.CharacterMaxExp;
        playerExp.text = GameManager.Instance.Player.characterInfo.CharacterExp.ToString();
        playerMaxExp.text = GameManager.Instance.Player.characterInfo.CharacterMaxExp.ToString();
    }
    private void SetExplain()
    {
        playerExplain.text = GameManager.Instance.Player.characterInfo.CharacterExpain.ToString();
    }
    private void SetGold()
    {
        string playerGold = GameManager.Instance.Player.characterInfo.CharacterGold.ToString("C");
        gold.text = playerGold.ToString();
    }
}
