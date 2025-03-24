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
        playerName.text = GameManager.Instance.Player.playerName.ToString();
    }
    private void SetLevel()
    {
        playerLevel.text = GameManager.Instance.Player.playerLevel.ToString();
    }
    private void SetExp()
    {
        playerExpBar.fillAmount = (float)GameManager.Instance.Player.playerExp / (float)GameManager.Instance.Player.playerMaxExp;
        playerExp.text = GameManager.Instance.Player.playerExp.ToString();
        playerMaxExp.text = GameManager.Instance.Player.playerMaxExp.ToString();
    }
    private void SetExplain()
    {
        playerExplain.text = GameManager.Instance.Player.playerExpain.ToString();
    }
    private void SetGold()
    {
        string playerGold = GameManager.Instance.Player.playerGold.ToString("C");
        gold.text = playerGold.ToString();
    }
}
