using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    public float moveSpeed = 0.5f;
    private float bgWidth = 10.24f; // Manual olarak 10.24 yap
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
        // bgWidth = 10.24f; // Zaten yukarıda set ettik
    }

    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        
        if (transform.position.x < startPos.x - bgWidth)
        {
            transform.position = startPos;
        }
    }
}