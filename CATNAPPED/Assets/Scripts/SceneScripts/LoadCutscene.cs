using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadCutscene : MonoBehaviour
{
    public void LoadFinalCutscene()
    {
        SceneManager.LoadScene("EndScene");
    } 
}
