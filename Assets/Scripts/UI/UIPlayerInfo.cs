using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIPlayerInfo : MonoBehaviour
{
    // 플레이어 이름
    [SerializeField] TextMeshProUGUI playerName;
    // 플레이어 레벨
    [SerializeField] TextMeshProUGUI playerLevel;
    // 플레이어 최대 경험치
    [SerializeField] TextMeshProUGUI playerMaxExp;
    // 플레이어 현재 경험치
    [SerializeField] TextMeshProUGUI playerExp;
    // 플레이어 설명
    [SerializeField] TextMeshProUGUI playerExplain;
    // 플레이어 경험치 바
    [SerializeField] Image playerExpBar;
    // 플레이어 골드
    [SerializeField] TextMeshProUGUI gold;

    private void Start()
    {
        // 데이터 불러오기
        UpdatePlayerInfo();
    }

    public void UpdatePlayerInfo()
    {
        // 이름 설정
        SetName();
        // 레벨 설정
        SetLevel();
        // 경험치 설정
        SetExp();
        // 설명 설정
        SetExplain();
        // 골드 설정
        SetGold();
    }

    // 이름 설정 함수
    private void SetName()
    {
        // 플레이어 이름을 불러와 텍스트에 넣어주기
        playerName.text = GameManager.Instance.Player.characterInfo.CharacterName.ToString();
    }

    // 레벨 설정 함수
    private void SetLevel()
    {
        // 플레이어 레벨을 불러와 텍스트에 넣어주기
        playerLevel.text = GameManager.Instance.Player.characterInfo.CharacterLevel.ToString();
    }

    // 경험치 설정 함수
    private void SetExp()
    {
        // 플레이어 현재 경험치와 최대 경험치로 경험치 바 채우기
        playerExpBar.fillAmount = (float)GameManager.Instance.Player.characterInfo.CharacterExp / (float)GameManager.Instance.Player.characterInfo.CharacterMaxExp;
        // 플레이어 현재 경험치를 불러와 텍스트에 넣어주기
        playerExp.text = GameManager.Instance.Player.characterInfo.CharacterExp.ToString();
        // 플레이어 최대 경험치를 불러와 텍스트에 넣어주기
        playerMaxExp.text = GameManager.Instance.Player.characterInfo.CharacterMaxExp.ToString();
    }

    // 설명 설정 함수
    private void SetExplain()
    {
        // 플레이어 설명을 불러와 텍스트에 넣어주기 
        playerExplain.text = GameManager.Instance.Player.characterInfo.CharacterExpain.ToString();
    }

    // 골드 설정 함수
    private void SetGold()
    {
        // 플레이어 골드를 불러와 천원 단위로 컴마 찍기
        string playerGold = GameManager.Instance.Player.characterInfo.CharacterGold.ToString("C");
        // 골드 텍스트에 넣어주기 
        gold.text = playerGold.ToString();
    }
}
