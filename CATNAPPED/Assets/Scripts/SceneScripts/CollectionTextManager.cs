using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CollectionTextManager : MonoBehaviour
{
    public static CollectionTextManager Instance;

    GameObject screwCollectionText, ballCollectionText, flashlightCollectionText, magnetAndStringHint, flashlightHint;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        
        screwCollectionText = GameObject.Find("CollectedScrew");
        ballCollectionText = GameObject.Find("CollectWoodenball");
        flashlightCollectionText = GameObject.Find("CollectFlashlight");
        magnetAndStringHint = GameObject.Find("BathroomHint");
        flashlightHint = GameObject.Find("LRHint");
        screwCollectionText.SetActive(false);
        ballCollectionText.SetActive(false);
        flashlightCollectionText.SetActive(false);
    }

    public void WhenItemPickedUp() 
    {
        screwCollectionText.SetActive(true);
        ballCollectionText.SetActive(true);
        flashlightCollectionText.SetActive(true);
        magnetAndStringHint.SetActive(false);
        flashlightHint.SetActive(false);
    }

}
