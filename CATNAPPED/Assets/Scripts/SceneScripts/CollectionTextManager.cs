using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CollectionTextManager : MonoBehaviour
{
    GameObject screwCollectionText, ballCollectionText;

    private void Awake()
    {
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
