using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject VirtualCamera;
    public AudioSource source;
    public AudioClip clip;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        VirtualCamera.GetComponent<Animator>().Play("AnimRotation");
        source.PlayOneShot(clip);
    }
}
