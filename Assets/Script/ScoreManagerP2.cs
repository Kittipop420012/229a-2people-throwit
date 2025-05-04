using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManagerP2 : MonoBehaviour
{
    public static ScoreManagerP2 Instance;
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
        GameData.scoreP2 = score; // เก็บลง GameData
        scoreText.text = "Player 2: " + score;
    }
}

