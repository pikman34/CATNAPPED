using UnityEngine;
using UnityEngine.SceneManagement;



public class LoadPipePuzzle : MonoBehaviour
{
    GameManager gameManager;

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();  
    }

    public void PipePuzzleLoad() 
    {
        if (!gameManager.completedGame) 
        {
            SceneManager.LoadScene("PipeScene");   
        }
    }
}
