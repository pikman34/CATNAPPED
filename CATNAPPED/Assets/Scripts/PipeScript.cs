using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PipeScript : MonoBehaviour
{

    float[] rotations = { 0,90,180,270 };

    public float[] correctRotation;
    [SerializeField]
    bool isPlaced = false;

    int PossibleRots = 1;

    private void Start()
    {
        PossibleRots = correctRotation.Length;
        int rand = Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3(0, 0, rotations[rand]);

        if(PossibleRots > 1) 
        {
            if(transform.eulerAngles.z == correctRotation[0] || transform.eulerAngles.z == correctRotation[1]) 
            {
                isPlaced = true;
            }
        }    
        else 
        {
            if(transform.eulerAngles.z == correctRotation[0]) 
            {
                isPlaced = true;
            }
        }
    }

    private void OnMouseDown()
    {
        transform.Rotate(0, 0, 90);
        transform.eulerAngles = new Vector3(0, 0, Mathf.Round(transform.eulerAngles.z));   

    if(PossibleRots > 1) 
        {
            if(transform.eulerAngles.z == correctRotation[0] || transform.eulerAngles.z == correctRotation[1] && isPlaced == false) 
            {
                isPlaced = true;
            }    
            else if(isPlaced == true) 
            {
                isPlaced = false;
            }
        }
        else 
        {
            if(transform.eulerAngles.z == correctRotation[0] && isPlaced == false) 
            {
                isPlaced = true;
            }    
            else if(isPlaced == true) 
            {
                isPlaced = false;
            }
        }
    }
}
