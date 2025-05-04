using UnityEngine;

public class ThrowingController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform throwPoint;
    public float arcHeight = 2f;
    public LayerMask obstacleLayer;
    public float checkDistance = 1.5f;
    public float arcHeightNearObstacle = 4f;

    private bool canThrow = true;
    public float throwCooldown = 1f;

    public void ThrowProjectileAtTarget(Transform target, Transform playerTransform)
    {
        if (!canThrow) return;

        canThrow = false; // เริ่มคูลดาวน์
        StartCoroutine(ThrowCooldown());

        // ตรวจว่ามีเสาอยู่ด้านหน้าไหม
        Vector2 checkDirection = playerTransform.localScale.x > 0 ? Vector2.right : Vector2.left;
        RaycastHit2D hit = Physics2D.Raycast(playerTransform.position, checkDirection, checkDistance, obstacleLayer);

        float selectedArcHeight = hit.collider != null ? arcHeightNearObstacle : arcHeight;

        GameObject projectile = Instantiate(projectilePrefab, throwPoint.position, Quaternion.identity);
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        rb.gravityScale = 1f;

        Vector2 start = throwPoint.position;
        Vector2 end = target.position;

        Vector2 velocity = CalculateArcVelocity(start, end, selectedArcHeight);
        rb.velocity = velocity;
    }

    private System.Collections.IEnumerator ThrowCooldown()
    {
        yield return new WaitForSeconds(throwCooldown);
        canThrow = true;
    }

    private Vector2 CalculateArcVelocity(Vector2 start, Vector2 end, float height)
    {
        float gravity = Mathf.Abs(Physics2D.gravity.y);
        float displacementY = end.y - start.y;
        Vector2 displacementX = new Vector2(end.x - start.x, 0);

        float timeUp = Mathf.Sqrt(2 * height / gravity);
        float timeDown = Mathf.Sqrt(2 * (height - displacementY) / gravity);
        float totalTime = timeUp + timeDown;

        Vector2 velocityY = Vector2.up * Mathf.Sqrt(2 * gravity * height);
        Vector2 velocityX = displacementX / totalTime;

        return velocityX + velocityY;
    }
}
