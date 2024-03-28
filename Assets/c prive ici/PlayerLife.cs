using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    private Vector3 _positionBase;

    void Start()
    {
        _positionBase = transform.position;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Death_Plat")
        {
            respawn();
        }
        if (collision.tag == "CheckPoint")
        {
            _positionBase = transform.position;
        }
    }

    private void respawn()
    {
        transform.position = _positionBase;
    }
}
