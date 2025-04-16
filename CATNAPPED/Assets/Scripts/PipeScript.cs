using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PipeScript : MonoBehaviour
{

    float[] rotations = { 0,90,180,270 };

    public float correctRotation;
    [SerializeField]
    bool isPlaced = false;

    private void Start()
    {
        int rand = Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3(0, 0, rotations[rand]);

                if(transform.eulerAngles.z == correctRotation) 
        {
            isPlaced = true;
        }    
    }

    private void OnMouseDown()
    {
        transform.Rotate(0, 0, 90);
        transform.eulerAngles = new Vector3(0, 0, Mathf.Round(transform.eulerAngles.z));   

        if(transform.eulerAngles.z == correctRotation && isPlaced == false) 
        {
            isPlaced = true;
        }    
        else if(isPlaced == true) 
        {
            isPlaced = false;
        }
    }
}
