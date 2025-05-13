using UnityEngine;

public class ItemTrigger : MonoBehaviour
{
    public InventoryItemData makeshiftHandle;
    private bool isItemAdded = false;
    GameObject brokenHandleHint, fixedHandleHint, finalCutsceneTrigger;

    private void Awake()
    {
        brokenHandleHint = GameObject.Find("3rdHintTrigger");
        fixedHandleHint = GameObject.Find("FinalHintTrigger");
        finalCutsceneTrigger = GameObject.Find("SendToFinalCutscene");

        fixedHandleHint.SetActive(false);
        finalCutsceneTrigger.SetActive(false);
    }

    private void OnEnable()
    {
        InventorySystem.Instance.OnInventoryChangedEvent += CheckForMakeshiftHandle;
    }

    private void OnDisable()
    {
        InventorySystem.Instance.OnInventoryChangedEvent -= CheckForMakeshiftHandle;
    }

    private void CheckForMakeshiftHandle()
    {
        InventoryItem item = InventorySystem.Instance.Get(makeshiftHandle);

        if (item != null && item.stackSize > 0)
        {
            if (!isItemAdded)
            {
                TriggerAction();
                isItemAdded = true;
                fixedHandleHint.SetActive(true);
            }
        }
        else
        {
            isItemAdded = false;
        }
    }

    public void TriggerAction() 
    {
        brokenHandleHint.SetActive(false);
        fixedHandleHint.SetActive(true);
    }

}
