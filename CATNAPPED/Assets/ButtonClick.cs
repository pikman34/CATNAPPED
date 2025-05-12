using UnityEngine;
using UnityEngine.Audio;

public class ButtonClick : MonoBehaviour
{
    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    public void PlayButtonSound1()
    {
        audioManager.PlaySFX(audioManager.button1);
    }

}
