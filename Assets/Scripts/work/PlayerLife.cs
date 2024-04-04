using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

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

    public Rigidbody2D playerRigidbody;
    public TMP_Text scoreText;
    public float velocityToScoreMultiplier = 0.1f;
    public bool isDead;
    private float score = 0f;

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
            isDead = true;
            

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
            isDead = true;

            StartCoroutine(AnimationDeath2());
        }

        if (isEnabled && collision.CompareTag("EndAnimation"))
        {
            isDead = true;

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

    void Update()
    {
        // Calculate score based on player's velocity
        float velocityMagnitude = playerRigidbody.velocity.magnitude;
        score += velocityMagnitude * velocityToScoreMultiplier;

        // Update UI text to display the score
        scoreText.text = "Score: " + Mathf.Round(score);

        if (isDead == true)
        {
            velocityToScoreMultiplier = 0f;
        }
    }
}
