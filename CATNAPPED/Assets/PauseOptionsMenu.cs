using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseOptionsMenu : MonoBehaviour
{
    public void BackPause()
    {
        SceneManager.LoadScene("PauseMenu");
    }

   
}
