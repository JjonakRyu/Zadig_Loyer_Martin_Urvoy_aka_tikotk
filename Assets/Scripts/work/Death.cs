using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public string sceneName;
    public bool isEnabled = true;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (isEnabled && collision.CompareTag("Player"))
        {
            SceneManager.LoadSceneAsync(sceneName);
        }
    }
}
