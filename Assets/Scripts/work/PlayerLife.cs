using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class PlayerLife : MonoBehaviour
{
    public Vector3 _positionBase;
    public bool isEnabled = true;
    public GameObject _player;
    public GameObject _particleDeath;
    public GameObject _playerEffect;
    public GameObject _deathUI;

    void Start()
    {
        _positionBase = transform.position;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Death_Plat")
        {
            respawn();
        }
        if (collision.tag == "CheckPoint")
        {
            _positionBase = transform.position;
        }

        if (isEnabled && collision.CompareTag("death"))
        {
            _player.GetComponent<SpriteRenderer>().enabled = false;
            _player.GetComponent<CapsuleController>().enabled = false;
            _particleDeath.SetActive(true);
            _playerEffect.SetActive(false);
            _player.GetComponent<Rigidbody2D>().simulated = false;

            StartCoroutine(AnimationDeath());
        }
    }

    IEnumerator AnimationDeath()
    {
        yield return new WaitForSeconds(2f);
        //SceneManager.LoadSceneAsync(sceneName);
        _deathUI.SetActive(true);
    }
    public void respawn()
    {
        transform.position = _positionBase;
    }
}
