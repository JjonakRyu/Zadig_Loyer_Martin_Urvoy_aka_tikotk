using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTag : MonoBehaviour
{
    public float invincibilityDuration = 1.0f;
    public GameObject player;
    public AudioSource source;
    public AudioClip clip;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.tag = "Invincibility";

            GetComponent<Collider2D>().enabled = false;
            player.GetComponent<PlayerLife>().isEnabled = false;
            source.PlayOneShot(clip);

            StartCoroutine(UnactivePlayerLife());
        }
    }

    IEnumerator UnactivePlayerLife()
    {
        yield return new WaitForSeconds(invincibilityDuration);
        {
            player.GetComponent<PlayerLife>().isEnabled = true;
        }
    }
}
