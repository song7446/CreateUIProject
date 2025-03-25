using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
    public Item item;

    public string GetName()
    {
        return item.displayName;
    }

    public string GetDescription()
    {
        return item.description;
    }
}
