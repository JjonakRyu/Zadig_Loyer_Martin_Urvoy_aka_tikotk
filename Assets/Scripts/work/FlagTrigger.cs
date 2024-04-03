using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagTrigger : MonoBehaviour
{
    public GameObject square;
    public GameObject particleCheckpoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        square.GetComponent<Animator>().Play("FlagReveal");
        particleCheckpoint.SetActive(true);
    }
}
