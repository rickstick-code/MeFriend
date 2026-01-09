using UnityEngine;

public class SubtleHorizontalMove : MonoBehaviour
{
    public float amplitude = 10f;
    public float speed = 0.5f;

    RectTransform rect;
    Vector2 startPos;

    void Awake()
    {
        rect = GetComponent<RectTransform>();
        startPos = rect.anchoredPosition;
    }

    void Update()
    {
        float offset = Mathf.Sin(Time.time * speed) * amplitude;
        rect.anchoredPosition = startPos + new Vector2(offset, 0f);
    }
}
