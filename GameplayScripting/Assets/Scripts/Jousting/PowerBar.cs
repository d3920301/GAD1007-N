using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PowerBar : MonoBehaviour
{
    PlayerInputActions playerInputActions;
    float playerInput = 0.0f;
    [SerializeField] float power = 1.0f;

    BoxCollider2D boxCollider2D;

    Rigidbody2D rigidbody2D;
    bool canMove = true;


    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Enable();

        // Determine Collider loc when object loads
        boxCollider2D = GetComponent<BoxCollider2D>();

        rigidbody2D = GetComponent<Rigidbody2D>();

        // Range shouldn't have hardcoded values. Collider scale looks static relative parent scale? (parent y = 2.5, col y scale = 1 and fits perfectly)
        // @todo: This does not work with sizes that are not 0.333 -_-
        //boxCollider2D.offset = new Vector2(0, Random.Range(0 - boxCollider2D.size.y, 0 + boxCollider2D.size.y));
    }

    // Update and Fixed update should be in another script for the arrow?
    private void Update()
    {
        playerInput = playerInputActions.PlayerJousting.PowerBar.ReadValue<float>();
    }

    private void FixedUpdate()
    {
        if (canMove)
        {
            rigidbody2D.AddForce(new Vector2(0, playerInput * power));
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("1");
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        Debug.Log(other);
    }
}
