using UnityEngine;

public class PlayerMovement : Movement
{
    PlayerInputActions playerInputActions;
    [SerializeReference] GameObject powerBar;
    PowerBar powerBarScript;

    // DEBUG ONLY - REMOVE ALL INSTANCES WHEN DONE - DONT TEST USER EXPERIENCE WITH POWERMOD ON
    //[SerializeField] float powerMod = 1.0f;

    protected override void Awake()
    {
        base.Awake();

        playerInputActions = new PlayerInputActions();
        playerInputActions.Enable();

        powerBarScript = powerBar.GetComponent<PowerBar>();

        GetComponent<Health>().OnPlayerDied += () => OnPlayerDied();

        //canMove = true;
    }

    protected override void Move()
    {
        // Unfortunantly putting this in movment doesnt work. It will just break out of base.Move() and wiill still run the AddForce code from the override.
        if (!canMove)
        {
            //Debug.Log(GetVelocity());
            if (GetVelocity() > 0.5)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetVelocity() * 0.95f, 0);
                //Debug.Log(name + " is slowing down!");
            }
            else if (GetVelocity() != 0)
            {
                GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                //Debug.Log(name + " has stopped!");
            }
            return;
        }

        // This definently works. STOP TESTING IT!!
        rb.AddForce(Vector2.left * powerBarScript.powerOutput/* * powerMod*/);
        //Debug.Log(Vector2.left * powerBarScript.powerOutput/* * powerMod*/);

        //Debug.Log(rb.velocity.x);
    }

    private void OnPlayerDied()
    {
        SetCanMove(false);

        // Play death animation
    }
}
