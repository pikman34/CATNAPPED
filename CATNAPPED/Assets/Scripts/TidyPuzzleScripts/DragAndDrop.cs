using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public GameObject selectedPiece;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.transform.CompareTag("Puzzle")) 
            {
                if (!hit.transform.GetComponent<PiecesScript>().InRightPosition) 
                {
                    selectedPiece = hit.transform.gameObject;
                    selectedPiece.GetComponent<PiecesScript>().Selected = true;
                }
            }
        }

        if (Input.GetMouseButtonUp(0)) 
        {
            if (selectedPiece != null) 
            {
                selectedPiece.GetComponent<PiecesScript>().Selected = false;
                selectedPiece = null;
            }        
        }

        if (selectedPiece != null) 
        {
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            selectedPiece.transform.position = new Vector3(MousePoint.x, MousePoint.y, 0);
        }
    }
}
