using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public string sceneName;
    public bool isEnabled = true;
    public GameObject player;
    public GameObject particleDeath;
    public GameObject trail;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (isEnabled && collision.CompareTag("death"))
        {
            player.GetComponent<SpriteRenderer>().enabled = false;
            player.GetComponent<CapsuleController>().enabled = false;
            particleDeath.SetActive(true);
            trail.SetActive(false);
            //player.GetComponent<Rigidbody2D>()
            player.GetComponent<Rigidbody2D>().simulated = false;

            StartCoroutine(AnimationDeath());
        }
    }

    IEnumerator AnimationDeath()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadSceneAsync(sceneName);
    }
}
