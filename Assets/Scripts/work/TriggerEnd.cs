using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnd : MonoBehaviour
{
    public GameObject player;
    public Color defaultColor = Color.white;
    public ParticleSystem particleSystem1;
    public ParticleSystem particleSystem2;
    public GameObject virtualCamera;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.GetComponent<CapsuleController>().enabled = false;
        player.GetComponent<SpriteRenderer>().color = defaultColor;
        player.GetComponent<Rigidbody2D>().gravityScale = 1.8f;
        particleSystem1.Stop();
        particleSystem2.Stop();
        virtualCamera.GetComponent<Animator>().Play("AnimOut");
    }

}
