using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIPlayerInfo : MonoBehaviour
{
    TextMeshProUGUI playerName;
    TextMeshProUGUI playerLevel;
    TextMeshProUGUI playerMaxExp;
    TextMeshProUGUI playerExp;
    TextMeshProUGUI playerExplain;
    Image playerExpBar;
    TextMeshProUGUI gold;

    private void Awake()
    {
        playerName = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        playerLevel = transform.GetChild(1).GetChild(1).GetComponent<TextMeshProUGUI>();
        playerMaxExp = transform.GetChild(2).GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>();
        playerExp = transform.GetChild(2).GetChild(1).GetChild(1).GetComponent<TextMeshProUGUI>();
        playerExpBar = transform.GetChild(2).GetChild(1).GetComponent<Image>();
        playerExplain = transform.GetChild(3).GetChild(0).GetComponent<TextMeshProUGUI>();
        gold = transform.GetChild(4).GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        SetName();
        SetLevel();
        SetExp();
        SetExplain();
        SetGold();
    }

    public void SetName()
    {
        playerName.text = GameManager.Instance.Player.playerName.ToString();
    }
    public void SetLevel()
    {
        playerLevel.text = GameManager.Instance.Player.playerLevel.ToString();
    }
    public void SetExp()
    {
        playerExpBar.fillAmount = (float)GameManager.Instance.Player.playerExp / (float)GameManager.Instance.Player.playerMaxExp;
        playerExp.text = GameManager.Instance.Player.playerExp.ToString();
        playerMaxExp.text = GameManager.Instance.Player.playerMaxExp.ToString();
    }
    public void SetExplain()
    {
        playerExplain.text = GameManager.Instance.Player.playerExpain.ToString();
    }
    public void SetGold()
    {
        string playerGold = GameManager.Instance.Player.playerGold.ToString("C");
        gold.text = playerGold.ToString();
    }
}
