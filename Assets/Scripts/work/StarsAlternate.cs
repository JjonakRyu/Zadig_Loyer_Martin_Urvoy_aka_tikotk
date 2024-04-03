using UnityEngine;

public class BStarsAlternate : MonoBehaviour
{
    public Sprite[] backgrounds; // Array to hold your background sprites
    public float interval = 5f; // Interval in seconds between background changes

    private SpriteRenderer spriteRenderer;
    private int currentIndex = 0;
    private float timer = 0f;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (backgrounds.Length > 0)
        {
            // Set initial background
            spriteRenderer.sprite = backgrounds[currentIndex];
        }
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= interval)
        {
            // Change background
            currentIndex = (currentIndex + 1) % backgrounds.Length;
            spriteRenderer.sprite = backgrounds[currentIndex];
            timer = 0f;
        }
    }
}

