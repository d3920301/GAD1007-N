using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    // Create reference to components
    Rigidbody2D rb;
    // Create reference to input
    PlayerInputActions playerInputActions;

    // Other Variables
    float movementVec = 0.0f;
    bool canMove = true;
    [SerializeField] float power = 1.0f;

    // Do this while we load the scene
    void Awake()
    {
        // Set up new input system
        playerInputActions = new PlayerInputActions();
        playerInputActions.Enable();

        // Get any components we need
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Do input logic every frame to ensure we dont miss keypresses
        movementVec = playerInputActions.PlayerJousting.Move.ReadValue<float>();   
    }

    // Do physics stuff in the physics process
    private void FixedUpdate()
    {
        // Player movement
        if (canMove)
        {
            rb.AddForce(new Vector2(movementVec, 0) * power);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("2");
    }
}
