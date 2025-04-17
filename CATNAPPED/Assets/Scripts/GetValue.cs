using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class GetValue : MonoBehaviour
{
    [SerializeField] InventorySystem inventory;

    public void LoadSceneAndKeepValue() 
    {
        string dataToKeep = string.Join( ",", inventory.inventory);
        StaticData.valueToKeep = dataToKeep;
        SceneManager.LoadScene("PipeScene");
    }
}
