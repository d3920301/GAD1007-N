using UnityEngine;

public class TownPlayerMovement : MonoBehaviour
{
    PlayerInputActions playerInputActions;
    Rigidbody2D rb;
    [SerializeField] float speed = 1.0f;
    public bool canTp = true;

    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Enable();

        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        Move();
    }

    private void Move()
    {
        rb.velocity = playerInputActions.Town.Move.ReadValue<Vector2>().normalized * speed;
    }

    // Teleport cooldown
    public void TPCD(float cd = 5.0f)
    {
        canTp = false;
        Invoke(nameof(AllowTP), cd);
    }

    private void AllowTP()
    {
        canTp = true;
    }
}
