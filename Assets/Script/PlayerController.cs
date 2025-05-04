using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public enum PlayerID { Player1, Player2 }
    public PlayerID playerID = PlayerID.Player1;

    public float moveSpeed = 5f;
    public ThrowingController throwingController; // การอ้างอิงถึง ThrowingController สคริปต์
    public Vector2 throwDirectionPlayer1 = new Vector2(1, 1); // ทิศทางการปาของผู้เล่น 1
    public Vector2 throwDirectionPlayer2 = new Vector2(-1, 1); // ทิศทางการปาของผู้เล่น 2
    public Transform enemyTarget;

    void Update()
{
    float moveX = 0f;

    if (playerID == PlayerID.Player1)
    {
        moveX = (Input.GetKey(KeyCode.A) ? -1f : 0f) + (Input.GetKey(KeyCode.D) ? 1f : 0f);
        if (Input.GetKeyDown(KeyCode.W))
        {
        throwingController.ThrowProjectileAtTarget(enemyTarget, this.transform);
        }

    }
    else if (playerID == PlayerID.Player2)
    {
        moveX = (Input.GetKey(KeyCode.LeftArrow) ? -1f : 0f) + (Input.GetKey(KeyCode.RightArrow) ? 1f : 0f);
        if (Input.GetKeyDown(KeyCode.Return))
        {
            throwingController.ThrowProjectileAtTarget(enemyTarget, this.transform);
        }
    }

    Vector3 movement = new Vector3(moveX, 0f, 0f).normalized;
    transform.position += movement * moveSpeed * Time.deltaTime;
}
}
