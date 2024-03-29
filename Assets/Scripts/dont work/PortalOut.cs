using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalOut : MonoBehaviour
{

    public GameObject Particle;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Particle.SetActive(true);
        }
    }
}
