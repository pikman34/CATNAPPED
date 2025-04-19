using UnityEditor.UI;
using UnityEngine;
using UnityEngine.SceneManagement;



public class LoadPipePuzzle : MonoBehaviour
{
    PuzzleProgressionTracker pipePuzzle;

    private void Awake()
    {
        pipePuzzle = GameObject.Find("ProgressionTracker").GetComponent<PuzzleProgressionTracker>();
    }

    public void PipePuzzleLoad() 
    {
        if (!pipePuzzle.pipePuzzleComplete) 
        {
            SceneManager.LoadScene("PipeScene");   
        }
    }

    public void NextTrigger() 
    {
        if (pipePuzzle.pipePuzzleComplete)
        {
            var pipePuzzleTrigger = GameObject.Find("SinkTrigger").GetComponent<LoadPipePuzzle>();
            Destroy(pipePuzzleTrigger);
        }
    }
}
