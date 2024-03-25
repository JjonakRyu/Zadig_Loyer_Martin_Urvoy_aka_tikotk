using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // Reference to the player's transform
    public float minOrthographicSize = 5f; // Minimum orthographic size
    public float maxOrthographicSize = 10f; // Maximum orthographic size
    public float zoomFactor = 0.1f; // How much to zoom based on the player's speed

    private Rigidbody2D playerRigidbody;
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
        if (target != null)
        {
            playerRigidbody = target.GetComponent<Rigidbody2D>();
        }
    }

    void Update()
    {
        if (target != null && playerRigidbody != null)
        {
            // Calculate the current orthographic size based on the player's speed
            float targetOrthographicSize = Mathf.Clamp(mainCamera.orthographicSize - playerRigidbody.velocity.magnitude * zoomFactor, minOrthographicSize, maxOrthographicSize);
            // Smoothly interpolate towards the target orthographic size
            mainCamera.orthographicSize = Mathf.Lerp(mainCamera.orthographicSize, targetOrthographicSize, Time.deltaTime * 5f);
        }
    }
}
