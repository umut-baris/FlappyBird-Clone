using UnityEngine;
using System.Collections;

public class GroundMovement : MonoBehaviour
{
    public float moveSpeed = 2f;
    
    void Update()
    {
        // Sola doğru hareket
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }
}