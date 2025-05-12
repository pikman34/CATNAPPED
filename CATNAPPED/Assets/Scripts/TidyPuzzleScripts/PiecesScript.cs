using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PiecesScript : MonoBehaviour
{
    private Vector3 RightPosition;
    public bool InRightPosition;
    public bool Selected;
    private BoxCollider2D pieces;
    private bool hasReportedCorrect;
    TidyGameManager tidyGameManager;

    void Start()
    {
        RightPosition = transform.position;
        transform.position = new Vector3(Random.Range(157f, 171f), -114f, 0f);
        pieces = GetComponent<BoxCollider2D>();
    }

    void Awake()
    {
        tidyGameManager = GameObject.Find("TidyGameManager").GetComponent<TidyGameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, RightPosition) < 0.5f) 
        {
            if (!Selected)
            {
                transform.position = RightPosition;
                InRightPosition = true;

                if (!hasReportedCorrect) 
                {
                    tidyGameManager.correctMove();
                    hasReportedCorrect = true;
                }
            }

        }

        if (InRightPosition) 
        {
            pieces.enabled = !pieces.enabled;
        }
    }

}
