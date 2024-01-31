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
    float movementVec;
    bool canMove;

    // Do this while we load the scene
    void Awake()
    {
        // Set up new input system
        playerInputActions = new PlayerInputActions();
        playerInputActions.Enable();

        // Get any components we need
        rb = GetComponent<Rigidbody2D>();
    }

    // Called once before update
    private void Start()
    {
        // Set canMove here so we dont get any unexpected behaviour in game
        canMove = true;
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
            rb.AddForce(new Vector2(movementVec, 0));
        }
    }
}
