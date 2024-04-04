using UnityEngine;
using UnityEngine.UI;

public class ButtonScaler : MonoBehaviour
{
    public float scaleFactor = 1.2f; // Scale factor when the mouse is over the button
    public float normalScale = 1.0f; // Normal scale of the button

    private Vector3 originalScale;
    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        originalScale = transform.localScale;
    }

    private void Update()
    {
        if (button.interactable)
        {
            Vector3 targetScale = IsMouseOver() ? originalScale * scaleFactor : originalScale;
            transform.localScale = Vector3.Lerp(transform.localScale, targetScale, Time.deltaTime * 10f);
        }
    }

    private bool IsMouseOver()
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        Vector2 localMousePosition = rectTransform.InverseTransformPoint(Input.mousePosition);
        return rectTransform.rect.Contains(localMousePosition);
    }
}
