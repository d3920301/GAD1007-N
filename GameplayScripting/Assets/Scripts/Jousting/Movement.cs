/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
* BASE MOVEMENT SCRIPT                                                                         *
* This script has everything other movement scripts will need.                                 *
* We need this script because sometimes other scripts need to get player movement information. *
* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
using UnityEngine;

public class Movement : MonoBehaviour
{
    protected Rigidbody2D rb = null;
    protected bool canMove = false;

    protected virtual void Awake()
    {
        //Debug.Log("Movement Awake");

        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    protected virtual void Move()
    {
        //Debug.Log("Movement Move");
    }

    public void SetCanMove(bool newCanMove)
    {
        canMove = newCanMove;
        //Debug.Log("SetCanMove called");
    }

    public float GetVelocity()
    {
        return rb.velocity.x;
    }

    public void ZeroVelocity()
    {
        rb.velocity = Vector2.zero;
    }
}
