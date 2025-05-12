using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
    public InventoryItemData referenceItem;

    public List<ItemRequirement> requirements;

    public bool removeRequirementsOnPickup;

    public void OnHandlePickupItem() 
    {
        if (MeetsRequirements()) 
        {
           if (removeRequirementsOnPickup) 
           {
                RemoveRequirements();
           } 
        
                InventorySystem.Instance.Add(referenceItem);
                Destroy(gameObject);
        }
    }

    private bool MeetsRequirements() 
    {
        foreach (ItemRequirement requirement in requirements) 
        {
            if (!requirement.HasRequirement()) { return false; }
        }
        
        return true;
    }    

    private void RemoveRequirements() 
    {
        foreach (ItemRequirement requirement in requirements) 
        {
            for (int i=0; i<requirement.amount; i++) 
            {
                InventorySystem.Instance.Remove(requirement.itemData);
            }
        }
    }
}
