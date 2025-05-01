using UnityEngine;

public class InventoryBar : MonoBehaviour
{
    public void Start()
    {
        InventorySystem.current.OnInventoryChangedEvent += OnUpdateInventory;
    }

    private void OnUpdateInventory() 
    {
        foreach(Transform t in transform) 
        {
            Destroy(t.gameObject);
        }

        DrawInventory();
    }

    public void DrawInventory() 
    {
        foreach(InventoryItem item in InventorySystem.current.inventory)
        {
            AddInventorySlot(item);
        }
    }

    public void AddInventorySlot(InventoryItem item) 
    {

    }
}
