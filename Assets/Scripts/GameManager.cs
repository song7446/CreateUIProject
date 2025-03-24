using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public UIManager UIManager;
    
    public Character Player;

    private void Awake()
    {
        Instance = this;
    }
}
