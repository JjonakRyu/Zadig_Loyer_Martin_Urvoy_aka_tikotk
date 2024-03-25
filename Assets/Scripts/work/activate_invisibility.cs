using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activate_invisibility : MonoBehaviour
{
    public float invincibilityDuration = 1.0f;
    public GameObject invincibility;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        invincibility.GetComponent<invincibility>().enabled = true;
        StartCoroutine(Invicibilitytime());
    }

    IEnumerator Invicibilitytime()
    {
        yield return new WaitForSeconds(invincibilityDuration);
        invincibility.GetComponent<invincibility>().enabled = false;

        GameObject[] deathObjects;
        deathObjects = GameObject.FindGameObjectsWithTag("death");

        foreach (GameObject deathObject in deathObjects)
        {
            deathObject.GetComponent<lamort>().isEnabled = true;
        }
    }
}

//ACTIVATE invincibility TO PREVENT PLAYER TO DIE AND TURN isEnable FROM lamort BACK TO ACTIVE TO KILL A PLAYER 
