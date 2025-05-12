using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("HouseScene");
    }

     public void Options()
    {
        SceneManager.LoadScene("OptionsMenu");
    }


    public void QuitGame()
    {
        Application.Quit();
    }

}
