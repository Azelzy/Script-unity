using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;
    private int score = 0;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void AddScore(int value)
    {
        score += value;
        scoreText.text = "Score: " + score;
    }
}
