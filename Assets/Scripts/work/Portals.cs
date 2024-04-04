using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portals : MonoBehaviour
{

    public Transform end;
    public GameObject Particle;
    public AudioSource source;
    public AudioClip clip;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.transform.position = end.transform.position;
            Particle.SetActive(true);
            source.PlayOneShot(clip);
        }
    }
}

