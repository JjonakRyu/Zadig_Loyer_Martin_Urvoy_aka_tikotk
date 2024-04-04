using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeUpOverTime : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        source.PlayOneShot(clip);
    }
}
