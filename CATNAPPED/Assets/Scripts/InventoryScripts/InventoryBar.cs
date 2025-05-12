using UnityEngine;

public class InventoryBar : MonoBehaviour
{
    public void Start()
    {
        InventorySystem.Instance.OnInventoryChangedEvent += OnUpdateInventory;
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
        foreach(InventoryItem item in InventorySystem.Instance.inventory)
        {
            AddInventorySlot(item);
        }
    }

    public void AddInventorySlot(InventoryItem item) 
    {

    }
}
