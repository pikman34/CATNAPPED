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

    public void MainMenuLoad()
    {
        SceneManager.LoadScene("MainMenu");
    } //this is for last scene in game not used in main menu

    public void QuitGame()
    {
        Application.Quit();
    }

}
