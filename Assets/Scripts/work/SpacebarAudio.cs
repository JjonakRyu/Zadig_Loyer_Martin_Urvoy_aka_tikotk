using UnityEngine;

public class SpacebarAudio : MonoBehaviour
{
    public AudioClip audioClip;
    private AudioSource audioSource;

    // Volume level (0.0 to 1.0)
    public float volume = 0.5f;

    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();

        // Assign the audio clip to the AudioSource
        audioSource.clip = audioClip;

        // Set the initial volume
        audioSource.volume = volume;
    }

    void Update()
    {
        // Check if the space bar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Start playing the audio clip on loop
            audioSource.loop = true;
            audioSource.Play();
        }

        // Check if the space bar is released
        if (Input.GetKeyUp(KeyCode.Space))
        {
            // Stop playing the audio clip
            audioSource.Stop();
        }
    }
}


