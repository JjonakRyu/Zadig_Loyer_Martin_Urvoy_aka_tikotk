using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGravity : MonoBehaviour
{
    public GameObject player;
    private Rigidbody2D rb;
    public float newGravity = 1.0f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        rb = player.GetComponent<Rigidbody2D>();
        rb.gravityScale = newGravity;
    }
}
