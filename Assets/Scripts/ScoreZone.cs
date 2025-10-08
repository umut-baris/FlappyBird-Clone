using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            FindObjectOfType<ScoreManager>().AddScore(); // AddScore() metodunu çağır
        }
    }
}