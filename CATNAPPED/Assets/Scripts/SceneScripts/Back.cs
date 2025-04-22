using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    public void BackToScene() 
    {
        SceneManager.LoadScene("HouseScene");
    }
}
