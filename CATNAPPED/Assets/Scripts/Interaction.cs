using System;
using UnityEngine;
using UnityEngine.Events;

public class InteractionScript : MonoBehaviour
{
    public UnityEvent enteredTrigger, exitedTrigger, interacted;

    private bool insideTrigger;

    // Update is called once per frame
    void Update()
    {
        if (insideTrigger && Input.GetKeyDown(KeyCode.E))
        {
            interacted?.Invoke();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            enteredTrigger.Invoke();
            insideTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            exitedTrigger.Invoke();
            insideTrigger = false;
        }
    }
}