using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SppedBuff : MonoBehaviour
{
    public float multiplyer = 1.0f;
    
    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            
        }
    }
}
