using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CollectionTextManager : MonoBehaviour
{
    public static CollectionTextManager Instance;

    GameObject screwCollectionText, ballCollectionText;

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
        screwCollectionText.SetActive(false);
        ballCollectionText.SetActive(false);
    }

    public void WhenItemPickedUp() 
    {
        screwCollectionText.SetActive(true);
        ballCollectionText.SetActive(true);
    }

}
