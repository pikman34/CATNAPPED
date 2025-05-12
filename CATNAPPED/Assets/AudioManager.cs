using UnityEngine;

public class AudioManager : MonoBehaviour
{
 void Awake()
    {
        AudioManager[] existing = Object.FindObjectsByType<AudioManager>(FindObjectsSortMode.None);
        if (existing.Length > 1)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }
    
    [Header("------- Audio Source -------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("------- Audio Clip -------")]
    public AudioClip background;
    public AudioClip sink;
    public AudioClip pixelbeep;
    public AudioClip drawer;
    public AudioClip button1;
    public AudioClip button2;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
