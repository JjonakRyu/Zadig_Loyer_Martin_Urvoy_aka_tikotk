using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invincibility2 : MonoBehaviour
{
    void Start()
    {
        // Find all game objects with the tag "death"
        GameObject[] deathObjects = GameObject.FindGameObjectsWithTag("death");

        GameObject[] gameObjects;
        gameObjects = GameObject.FindGameObjectsWithTag("death");

        foreach (GameObject deathObject in deathObjects)
        {

            PlayerLife deathScript = deathObject.GetComponent<PlayerLife>();
            if (deathScript != null)
            {
                deathScript.enabled = false;
                Debug.Log("Death script disabled for: " + deathObject.name);
            }
            else
            {
                Debug.Log("No Death script found for: " + deathObject.name);
            }
        }

        //GameObject[] gameObjects;
        //gameObjects = GameObject.FindGameObjectsWithTag("death");

        //foreach (GameObject gameObject in gameObjects)
        //{
        //    GetComponent<Death>().enabled = false;
        //}
    }
}