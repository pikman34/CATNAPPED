using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;


public class ItemSlot : MonoBehaviour
{
    [SerializeField]
    private Image m_icon;

    public void Set(InventoryItem item) 
    {
        m_icon.sprite = item.data.icon;
    }

}