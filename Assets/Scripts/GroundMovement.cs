using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float groundWidth = 25.4f;
    private Vector3 startPos;
    private Transform[] groundPieces;
    private int pieceCount;

    void Start()
    {
        startPos = transform.position;
        
        // Tüm child'ları diziye al
        groundPieces = new Transform[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            groundPieces[i] = transform.GetChild(i);
        }
        pieceCount = groundPieces.Length;
        
        Debug.Log("Ground pieces: " + pieceCount);
    }

    void Update()
    {
        for (int i = 0; i < pieceCount; i++)
        {
            // Her ground parçasını hareket ettir
            groundPieces[i].Translate(Vector2.left * moveSpeed * Time.deltaTime);
            
            // Ekran dışına çıkınca en sağa taşı
            if (groundPieces[i].position.x < startPos.x - groundWidth)
            {
                Vector3 newPos = groundPieces[i].position;
                newPos.x += groundWidth * pieceCount;
                groundPieces[i].position = newPos;
            }
        }
    }
}