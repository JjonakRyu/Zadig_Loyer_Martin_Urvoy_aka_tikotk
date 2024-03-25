using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invincibility : MonoBehaviour
{
    private void Update()
    {
        GameObject[] deathObjects;
        deathObjects = GameObject.FindGameObjectsWithTag("death");

        foreach (GameObject deathObject in deathObjects)
        {
            deathObject.GetComponent<lamort>().isEnabled = false;
        }
    }
}

//NEED TO BE ACTIVATED BY activate_invisibility
//WHEN ACTIVATED THIS SCRIPT DISABLE THE SCRIPT "lamort" THAT KILL THE PLAYER


//void Start()
//{
//    GameObject[] deathObjects;
//    deathObjects = GameObject.FindGameObjectsWithTag("death");

//    foreach (GameObject deathObject in deathObjects)
//    {
//        deathObject.GetComponent<lamort>().isEnabled = false;
//    }

//}
//private void OnCollisionEnter2D(Collision2D collision)
//{
//    GameObject[] deathObjects;
//    deathObjects = GameObject.FindGameObjectsWithTag("death");

//    foreach (GameObject deathObject in deathObjects)
//    {
//        deathObject.GetComponent<lamort>().isEnabled = false;
//    }
//}