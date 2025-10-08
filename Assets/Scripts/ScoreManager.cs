using UnityEngine;
using TMPro; // TextMeshPro için

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;
    public TextMeshProUGUI scoreText; // Değişti!
    
    void Start()
    {
        score = 0;
        UpdateScoreText();
    }
    
    public void AddScore()
    {
        score++;
        UpdateScoreText();
    }
    
    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}