using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GiveValue : MonoBehaviour
{
    [SerializeField] InventorySystem inventory;

    public void Start()
    {
        string newInventory = StaticData.valueToKeep;
        inventory.inventory = new List<InventoryItem>((IEnumerable<InventoryItem>)newInventory.Split(',').ToList());
    }
}
