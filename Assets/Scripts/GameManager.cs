using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���� �Ŵ��� 
public class GameManager : MonoBehaviour
{
    // ���� �Ŵ��� �̱���
    public static GameManager Instance;

    // UI �Ŵ��� 
    public UIManager UIManager;
    
    // �÷��̾� 
    public Character Player;

    private void Awake()
    {
        // �ڱ� �ڽ� �־��ֱ�
        Instance = this;
    }
}
