using System;
using UnityEngine;

[Serializable]
public struct ItemRequirement
{
    public InventoryItemData itemData;
    public int amount;

    public bool HasRequirement() 
    {
        InventoryItem item = InventorySystem.Instance.Get(itemData);
        
        if (item == null || item.stackSize < amount) { return false; }

        return true;
    }
}
