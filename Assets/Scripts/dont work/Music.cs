using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    private void Start()
    {
        source.PlayOneShot(clip);
    }
}
