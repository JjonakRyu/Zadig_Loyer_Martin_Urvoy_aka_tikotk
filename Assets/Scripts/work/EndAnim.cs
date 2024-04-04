using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndAnim : MonoBehaviour
{
    public GameObject player;
    public GameObject explosion;
    public GameObject booster;
    public GameObject virtualCamera;
    public GameObject dust;
    public AudioSource source;
    public AudioClip clip;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.GetComponent<CapsuleController>().enabled = false;
        player.GetComponent<Rigidbody2D>().simulated = false;
        player.GetComponent<SpriteRenderer>().enabled = false;
        booster.SetActive(false);
        explosion.SetActive(true);
        dust.SetActive(true);
        virtualCamera.GetComponent<Animator>().Play("AnimCrash");
        source.PlayOneShot(clip);
    }
}
