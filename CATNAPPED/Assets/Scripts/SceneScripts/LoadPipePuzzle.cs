using Unity.Cinemachine;
using Unity.VisualScripting;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.SceneManagement;



public class LoadPipePuzzle : MonoBehaviour
{
    PuzzleProgressionTracker pipePuzzle;
    GameObject bathroomCam, pipeExitButton, magnetAndStringHint;

    private void Awake()
    {
        pipePuzzle = GameObject.Find("ProgressionTracker").GetComponent<PuzzleProgressionTracker>();
        magnetAndStringHint = GameObject.Find("Magnet&StringHint");
    
        if (!pipePuzzle.pipePuzzleComplete) 
        {
            bathroomCam = GameObject.Find("BathroomCamera");
            pipeExitButton = GameObject.Find("PipeExitButton");
            bathroomCam.SetActive(false);
            pipeExitButton.SetActive(false);
            magnetAndStringHint.SetActive(false);
        }
    }

    public void PipePuzzleLoad() 
    {
        if (!pipePuzzle.pipePuzzleComplete) 
        {
            bathroomCam.SetActive(false);
            pipeExitButton.SetActive(true);
            SceneManager.LoadScene("PipeScene");
        }
        else 
        {
            NextTrigger();
        }
    }

    public void NextTrigger() 
    {
        if (pipePuzzle.pipePuzzleComplete)
        {
            magnetAndStringHint.SetActive(true);
            var pipePuzzleTrigger = GameObject.Find("SinkTrigger");
            Destroy(pipePuzzleTrigger);
        }
    }
}
