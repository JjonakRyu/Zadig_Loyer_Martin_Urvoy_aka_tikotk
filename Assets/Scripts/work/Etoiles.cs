using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Etoiles : MonoBehaviour
{
    public GameObject player;
    public GameObject booster;
    private Rigidbody2D rb;
    public float newSpeed = 1.0f;
    public float duration = 1.0f;
    public float endSpeed = 1.0f;


    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    player.GetComponent<Rigidbody2D>().gravityScale += newSpeed;
    //    yield return new WaitForSeconds(10f);
    //    player.GetComponent<Rigidbody2D>().gravityScale -= newSpeed;
    //}

    //IEnumerator ChangeGravityScale()
    //{
    //    yield return new WaitForSeconds(2f);

    //    player.GetComponent<Rigidbody2D>().gravityScale -= newSpeed;
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.GetComponent<CapsuleController>().enabled = false;
        booster.SetActive(false);
        rb = player.GetComponent<Rigidbody2D>();
        rb.gravityScale = newSpeed;
        StartCoroutine(changeSpped());
    }

    IEnumerator changeSpped()
    {
        yield return new WaitForSeconds(duration);
        rb.gravityScale = endSpeed;
        player.GetComponent<CapsuleController>().enabled = true;
        booster.SetActive(true);
    }
}