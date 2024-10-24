using UnityEngine;

public class PowerBar : MonoBehaviour
{
    PlayerInputActions playerInputActions;
    // We need a reference to the arrow to move.
    [SerializeReference] GameObject arrow;
    // And its rigidbody.
    [SerializeField] float arrowPower = 1.0f;
    [SerializeReference] GameObject arrowUpperBound;
    [SerializeReference] GameObject arrowLowerBound;
    // Get ref to powerzone
    [SerializeReference] GameObject powerZone;
    [SerializeField] float noPowerBoost = 1.0f;
    [SerializeField] float powerBoost = 5.0f;
    BoxCollider2D arrowBoxCol;
    Rigidbody2D arrowRb;
    BoxCollider2D powerZoneBoxCol;
    float playerInput;
    public float powerOutput = 1.0f;

    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Enable();

        arrowBoxCol = arrow.GetComponent<BoxCollider2D>();
        arrowRb = arrow.GetComponent<Rigidbody2D>();

        powerZoneBoxCol = powerZone.GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        playerInput = playerInputActions.Jousting.PowerBar.ReadValue<float>();
        //Debug.Log("PowerBar Player Input: " + playerInput);

        if (powerZoneBoxCol.IsTouching(arrowBoxCol))
        {
            powerOutput = powerBoost;
            //Debug.Log("Arrow Entered Collider");
        }
        else
        {
            powerOutput = noPowerBoost;
            //Debug.Log("Arrow Left Collider");
        }

        // Set arrow and bound positions to player powerbar pos
        // The 0.1f is the offset from the powerbar
        arrow.transform.position = new Vector3(this.transform.position.x + 0.1f, arrow.transform.position.y, 0);
        arrowUpperBound.transform.position = new Vector3(this.transform.position.x, arrowUpperBound.transform.position.y, 0);
        arrowLowerBound.transform.position = new Vector3(this.transform.position.x, arrowLowerBound.transform.position.y, 0);
    }

    private void FixedUpdate()
    {
        ManageArrow();
    }

    private void ManageArrow()
    {
        arrowRb.AddForce(Vector2.up * playerInput * arrowPower);
    }
}
