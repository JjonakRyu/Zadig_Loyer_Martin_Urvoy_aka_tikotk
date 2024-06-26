using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public GameObject VirtualCamera;
    public AudioSource source;
    public AudioClip clip;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        VirtualCamera.GetComponent<Animator>().Play("AnimRotationBack");
        source.PlayOneShot(clip);
    }
}
