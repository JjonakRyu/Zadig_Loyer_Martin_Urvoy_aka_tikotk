using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    private Vector3 positionBase;

    void Start()
    {
        positionBase = transform.position;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "death")
        {
            StartCoroutine(_respawn());
        }
        if (collision.tag == "CheckPoint")
        {
            positionBase = transform.position;  
        }
    }

    private void respawn()
    {
        transform.position = positionBase;
    }

    IEnumerator _respawn()
    {
        yield return new WaitForSeconds(5);

        respawn();
    }
}
