using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{

    public GameObject PipesHolder;
    public GameObject[] Pipes;
    ScrewSpawn checkScrew;
    PipeScript win;

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

    public void correctMove() 
    {
        correctedPipes += 1;

        Debug.Log("correct move");

        if(correctedPipes == totalPipes) 
        {
            Debug.Log("You Win!");
            checkScrew.screwIsCollectible = true;
            win.completedGame = true;
        }
    }


    public void wrongMove() 
    {
        correctedPipes -= 1;

        Debug.Log("incorrect move");
    }
}
