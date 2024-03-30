using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject VirtualCamera;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        VirtualCamera.GetComponent<Animator>().Play("AnimRotation");
    }
}
