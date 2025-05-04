using UnityEngine;

public class RockDestroy : MonoBehaviour
{
    public string thrownBy = "Player1"; // หินโยนโดย Player1

    private void OnCollisionEnter2D(Collision2D collision)
{
    Debug.Log("โดนอะไร: " + collision.gameObject.name);

    if (collision.gameObject.CompareTag("Player2"))
    {
        Debug.Log("โดน Player2");
        ScoreManagerP1.Instance.AddScore(1);
        Destroy(gameObject);
    }
        else if (collision.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}
