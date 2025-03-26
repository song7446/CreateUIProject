using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 게임 매니저 
public class GameManager : MonoBehaviour
{
    // 게임 매니저 싱글톤
    public static GameManager Instance;

    // UI 매니저 
    public UIManager UIManager;
    
    // 플레이어 
    public Character Player;

    private void Awake()
    {
        // 자기 자신 넣어주기
        Instance = this;
    }
}
