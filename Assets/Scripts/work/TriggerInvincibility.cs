using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerInvincibility : MonoBehaviour
{
    public GameObject effect;
    public GameObject plateform;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Invincibility"))
        {
            effect.SetActive(true);
            plateform.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
