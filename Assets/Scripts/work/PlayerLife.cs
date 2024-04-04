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
    public GameObject _deathUI2;
    public GameObject virtualCamera;
    public GameObject boosterDeath;
    public AudioSource source;
    public AudioClip clip;

    void Start()
    {
        _positionBase = transform.position;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

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
            virtualCamera.GetComponent<Animator>().Play("AnimDeath");
            source.PlayOneShot(clip);
            boosterDeath.GetComponent<SpacebarAudio>().enabled = false;

            StartCoroutine(AnimationDeath());
        }

        if (isEnabled && collision.CompareTag("Death_Plat"))
        {
            _player.GetComponent<SpriteRenderer>().enabled = false;
            _player.GetComponent<CapsuleController>().enabled = false;
            _particleDeath.SetActive(true);
            _playerEffect.SetActive(false);
            _player.GetComponent<Rigidbody2D>().simulated = false;
            virtualCamera.GetComponent<Animator>().Play("AnimDeath");
            source.PlayOneShot(clip);
            boosterDeath.GetComponent<SpacebarAudio>().enabled = false;

            StartCoroutine(AnimationDeath2());
        }

        if (isEnabled && collision.CompareTag("EndAnimation"))
        {
            StartCoroutine(EndingAnimation());
        }
    }

    IEnumerator AnimationDeath()
    {
        yield return new WaitForSeconds(2f);
        //SceneManager.LoadSceneAsync(sceneName);
        _deathUI.SetActive(true);
    }

    IEnumerator AnimationDeath2()
    {
        yield return new WaitForSeconds(2f);
        //SceneManager.LoadSceneAsync(sceneName);
        _deathUI2.SetActive(true);
    }

    IEnumerator EndingAnimation()
    {
        yield return new WaitForSeconds(2f);
        //SceneManager.LoadSceneAsync(sceneName);
        _deathUI.SetActive(true);
    }
    //public void respawn()
    //{
    //    transform.position = _positionBase;
    //}
}
