using UnityEngine;

public class TidyGameManager : MonoBehaviour
{
    public GameObject TidyPuzzle, tidyExitButton;
    public GameObject[] TidyObjects;
    public bool completedGame = false;

    WoodenballSpawn woodenballChecker;

    PuzzleProgressionTracker progressionTracker;

    [SerializeField]
    int totalTidyObjects = 0;

    [SerializeField]
    int correctTidyObjects = 0;

    void Start()
    {
        totalTidyObjects = TidyPuzzle.transform.childCount;
        
        TidyObjects = new GameObject[totalTidyObjects];

        for (int i = 0; i < TidyObjects.Length; i++) 
        {
            TidyObjects[i] = TidyPuzzle.transform.GetChild(i).gameObject;
        }

    }

    private void Awake()
    {

    }

    public void correctMove() 
    {
        correctTidyObjects += 1;

        if(correctTidyObjects == totalTidyObjects) 
        {
            Debug.Log("You Win!");

        }
    }
}
