using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadTidyPuzzle : MonoBehaviour
{
    PuzzleProgressionTracker tidyPuzzle;
    GameObject lrCam, tidyExitButton, flashlightHint;

    private void Awake()
    {
        tidyPuzzle = GameObject.Find("ProgressionTracker").GetComponent<PuzzleProgressionTracker>();
        flashlightHint = GameObject.Find("FlashlightHint");

        if (!tidyPuzzle.tidyPuzzleComplete) 
        {
            lrCam = GameObject.Find("LRCamera");
            tidyExitButton = GameObject.Find("TidyExitButton");
            lrCam.SetActive(false);
            tidyExitButton.SetActive(false);
            flashlightHint.SetActive(false);
        }
    }

    public void TidyPuzzleLoad() 
    {
        if (!tidyPuzzle.tidyPuzzleComplete) 
        {
            lrCam.SetActive(false);
            tidyExitButton.SetActive(true);
            SceneManager.LoadScene("TidyScene");   
        }
        else 
        {
            NextTrigger();
        }
    }

    public void NextTrigger() 
    {
        if (tidyPuzzle.tidyPuzzleComplete)
        {
            flashlightHint.SetActive(true);
            var tidyPuzzleTrigger = GameObject.Find("CouchTrigger").GetComponent<LoadPipePuzzle>();
            Destroy(tidyPuzzleTrigger);
        }
    }
}
