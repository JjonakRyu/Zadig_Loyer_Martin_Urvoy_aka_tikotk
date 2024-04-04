using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerInvincibility : MonoBehaviour
{
    public GameObject effect;
    public GameObject plateform;
    public GameObject repere1;
    public GameObject repere2;
    public AudioSource source;
    public AudioClip clip;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Invincibility"))
        {
            effect.SetActive(true);
            plateform.GetComponent<SpriteRenderer>().enabled = false;
            repere1.GetComponent<SpriteRenderer>().enabled = false;
            repere2.GetComponent<SpriteRenderer>().enabled = false;
            source.PlayOneShot(clip);
        }
    }
}
