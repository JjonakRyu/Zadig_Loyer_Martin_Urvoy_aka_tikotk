using System.Collections;
using UnityEngine;

public class CapsuleController : MonoBehaviour
{
    public float defaultFallSpeed = 20f; // Default maximum fall speed
    public float alternateFallSpeed = 5f; // Alternate maximum fall speed
    public Color defaultColor = Color.white; // Default color
    public Color alternateColor = Color.red; // Alternate color
    public ParticleSystem particleSystem1; // Reference to the first particle system
    public ParticleSystem particleSystem2; // Reference to the second particle system

    private Rigidbody2D rb;
    private float maxFallSpeed; // Current maximum fall speed
    private SpriteRenderer spriteRenderer;
    private bool spaceBarPressed = false; // Track if space bar is pressed

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        maxFallSpeed = defaultFallSpeed; // Start with default fall speed
        spriteRenderer = GetComponent<SpriteRenderer>();
        // Disable the particle systems at the start
        particleSystem1.Stop();
        particleSystem2.Stop();
    }

    void Update()
    {
        // Check for space bar input to toggle fall speed and change color
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(SmoothFallSpeedTransition(defaultFallSpeed, alternateFallSpeed, 0.5f));
            spaceBarPressed = true;
            // Start the particle systems when space key is pressed
            particleSystem1.Play();
            particleSystem2.Play();
            // Change color based on fall speed
            spriteRenderer.color = alternateColor;
        }

        // Check if space bar is released
        if (Input.GetKeyUp(KeyCode.Space))
        {
            spaceBarPressed = false;
            StartCoroutine(SmoothFallSpeedTransition(alternateFallSpeed, defaultFallSpeed, 0.5f));
            // Stop the particle systems when space key is released
            particleSystem1.Stop();
            particleSystem2.Stop();
            spriteRenderer.color = defaultColor; // Reset color to default
        }
    }

    IEnumerator SmoothFallSpeedTransition(float startSpeed, float endSpeed, float duration)
    {
        float elapsedTime = 0;
        while (elapsedTime < duration)
        {
            maxFallSpeed = Mathf.Lerp(startSpeed, endSpeed, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        maxFallSpeed = endSpeed; // Ensure the fall speed ends at the correct value
    }

    void FixedUpdate()
    {
        // Limit the fall speed if it exceeds the maximum
        if (rb.velocity.y < -maxFallSpeed && spaceBarPressed)
        {
            rb.velocity = new Vector2(rb.velocity.x, -maxFallSpeed);
        }
    }
}

