using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class InventorySystem : MonoBehaviour
{
    private Dictionary<InventoryItemData, InventoryItem> m_itemDictionary;
    public List<InventoryItem> inventory { get; private set; }

    private void Awake()
    {
        inventory = new List<InventoryItem>();
        m_itemDictionary = new Dictionary<InventoryItemData, InventoryItem>();   
    }

    public void Add(InventoryItemData referenceData) 
    {
        if(m_itemDictionary.TryGetValue(referenceData, out InventoryItem value)) 
        {
            value.AddToStack();
        }
        else 
        {
            InventoryItemData newItem = new InventoryItem(referenceData);
            inventory.Add(newItem);
            m_itemDictionary.Add(referenceData, newItem);
        }

    }

    public void Remove(InventoryItemData referenceData) 
    {
        if (m_itemDictionary.TryGetValue(referenceData, out InventoryItem value)) 
        {
            value.RemoveFromStack();

            if(value.stackSize == 0) 
            {
                inventory.Remove(value);
                m_itemDictionary.Remove(referenceData);
            }
        }
    }

}
