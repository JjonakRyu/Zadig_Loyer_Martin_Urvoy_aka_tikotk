using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformPosition : MonoBehaviour
{

    public Transform end;
    void OnTriggerEnter2D(Collider2D truc)
    {
        if (truc.tag == "Player")
        {
            truc.transform.position = end.transform.position;
        }
    }
}
