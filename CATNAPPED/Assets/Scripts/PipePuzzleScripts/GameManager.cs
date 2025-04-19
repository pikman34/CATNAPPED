using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class GameManager : MonoBehaviour
{

    public GameObject PipesHolder;
    public GameObject[] Pipes;
    public bool completedGame = false;

    ScrewSpawn screwChecker;

    PuzzleProgressionTracker progressionTracker;

    [SerializeField]
    int totalPipes = 0;
    [SerializeField]
    int correctedPipes = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        totalPipes = PipesHolder.transform.childCount;

        Pipes = new GameObject[totalPipes];

        for (int i = 0; i < Pipes.Length; i++) 
        {
            Pipes[i] = PipesHolder.transform.GetChild(i).gameObject;
        }        
    }

    private void Awake()
    {
        screwChecker = GameObject.Find("Screw Spawner").GetComponent<ScrewSpawn>();
        progressionTracker = GameObject.Find("ProgressionTracker").GetComponent<PuzzleProgressionTracker>();
    }

    public void correctMove() 
    {
        correctedPipes += 1;

        if(correctedPipes == totalPipes) 
        {
            Debug.Log("You Win!");
            progressionTracker.pipePuzzleComplete = true;
            screwChecker.UpdateSpawn();
        }
    }


    public void wrongMove() 
    {
        correctedPipes -= 1;
    }
}
