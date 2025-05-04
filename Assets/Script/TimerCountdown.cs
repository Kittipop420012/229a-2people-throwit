using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimerCountdown : MonoBehaviour
{
    public float timeRemaining = 10f;
    public TextMeshProUGUI timerText;

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;

            // คำนวณนาทีและวินาที
            int minutes = Mathf.FloorToInt(timeRemaining / 60f);
            int seconds = Mathf.FloorToInt(timeRemaining % 60f);
            timerText.text = string.Format("{0}:{1:00}", minutes, seconds);

            // เปลี่ยนสีเมื่อเหลือ ≤ 3 วินาที
            if (timeRemaining <= 3f)
            {
                timerText.color = Color.red;
            }
            else
            {
                timerText.color = Color.white;
            }
        }
            else
{
        timerText.text = "0:00";

    // เปรียบเทียบคะแนน
    if (GameData.scoreP1 > GameData.scoreP2)
        GameData.winnerName = "Player 1";
    else if (GameData.scoreP2 > GameData.scoreP1)
        GameData.winnerName = "Player 2";
    else
        GameData.winnerName = "No one";

    SceneManager.LoadScene("VictoryScene");
}
    }
}
