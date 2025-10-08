using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float speed = 2f;
    private float leftEdge; // Ekranın sol sınırı

    void Start()
    {
        // Ekranın sol sınırını hesapla (kamera solundan biraz dışarı)
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 2f;
    }

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        
        // Ekranın solundan çıktıysa sil
        if (transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }
    }
}