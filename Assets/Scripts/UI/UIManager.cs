using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public UIMainMenu UIMainMenu;
    public UIStatus UIStatus;
    public UIInventory UIInventory;

    private void Awake()
    {
        UIMainMenu = GetComponentInChildren<UIMainMenu>(true);
        UIStatus = GetComponentInChildren<UIStatus>(true);
        UIInventory = GetComponentInChildren<UIInventory>(true);
    }
}
