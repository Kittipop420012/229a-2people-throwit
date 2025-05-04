using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;

public class VictoryDisplay : MonoBehaviour
{
    public TextMeshProUGUI winText;
    public float delayTime = 10f; // ปรับเวลาได้ใน Inspector
    public string nextSceneName = "Credit"; // ปรับชื่อ scene ได้ใน Inspector

    void Start()
    {
        Debug.Log("Winner read as: " + GameData.winnerName);
        winText.text = GameData.winnerName + " Wins!";
        StartCoroutine(NextSceneAfterDelay());
    }

    IEnumerator NextSceneAfterDelay()
    {
        yield return new WaitForSeconds(delayTime);
        Debug.Log("Loading next scene: " + nextSceneName);
        SceneManager.LoadScene(nextSceneName);
    }
}
