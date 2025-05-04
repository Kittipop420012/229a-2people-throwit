using UnityEngine;

public class TorchDestroyer : MonoBehaviour
{
    public string thrownBy = "Player2"; // หินโยนโดย Player1

    private void OnCollisionEnter2D(Collision2D collision)
{
    Debug.Log("โดนอะไร: " + collision.gameObject.name);

    if (collision.gameObject.CompareTag("Player1"))
    {
        Debug.Log("โดน Player1");
        ScoreManagerP2.Instance.AddScore(1);
        Destroy(gameObject);
    }
        else if (collision.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}
