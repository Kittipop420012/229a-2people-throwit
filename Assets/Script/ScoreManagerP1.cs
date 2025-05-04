using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManagerP1 : MonoBehaviour
{
    public static ScoreManagerP1 Instance;
    public TextMeshProUGUI scoreText;
    private int score = 0;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void AddScore(int amount)
    {
        score += amount;
        GameData.scoreP1 = score; // เก็บลง GameData
        scoreText.text = "Player 1: " + score;
    }
}
