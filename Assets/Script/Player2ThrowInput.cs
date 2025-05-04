using UnityEngine;

public class Player2ThrowInput : MonoBehaviour
{
    public ThrowingController thrower; // อ้างถึง ThrowingController ของ Player 2
    public Transform target;           // เป้าหมายที่จะปาไป (เช่น Player 1)

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (thrower != null && target != null)
            {
                thrower.ThrowProjectileAtTarget(target, transform);
            }
            else
            {
                Debug.LogWarning("Thrower หรือ Target ยังไม่ได้ตั้งค่าใน Inspector!");
            }
        }
    }
}
