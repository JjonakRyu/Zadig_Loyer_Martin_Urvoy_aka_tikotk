using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invincibility : MonoBehaviour
{

    public float invincibilityDuration = 1.0f;
    private GameObject[] _DeathObjects;

    void Update()
    {
        _DeathObjects = GameObject.FindGameObjectsWithTag("death");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        foreach (GameObject deathObject in _DeathObjects)
        {
            deathObject.GetComponent<PlayerLife>().isEnabled = false;
        }

        StartCoroutine(Invicibilitytime());
    }

    IEnumerator Invicibilitytime()
    {
        yield return new WaitForSeconds(invincibilityDuration);

        //GameObject[] deathObjects;
        //deathObjects = GameObject.FindGameObjectsWithTag("death");

        foreach (GameObject deathObject in _DeathObjects)
        {
            deathObject.GetComponent<PlayerLife>().isEnabled = true;
        }
    }
}