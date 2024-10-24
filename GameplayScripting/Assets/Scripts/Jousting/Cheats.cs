/* * * * * * * * * * * * * * * * * * * *
* CHEAT MANAGER                         *
* Please LOG WHENEVER WE USE A CHEAT.   *
* So we can find and disable it easily! *
* * * * * * * * * * * * * * * * * * * */
using UnityEngine;
using UnityEngine.InputSystem;

public class Cheats : MonoBehaviour
{
    PlayerInputActions playerInputActions;

    RoundManager roundManager = null;

    private void Awake()
    {
        // Player input
        playerInputActions = new PlayerInputActions();
        playerInputActions.Enable();

        // Find and enable cheats
        // REMEMBER OT GO THROUGH EACH ONE AND SET ACCESS TO PRIVATE FOR RELEASE
        roundManager = GameObject.Find("RoundManager").GetComponent<RoundManager>();
        if (roundManager != null)
        {
            Debug.Log("CHEATS: Found Object With Round Manager Component!");
            playerInputActions.Cheats.NextRound.performed += NextRound;
        }
    }

    private void NextRound(InputAction.CallbackContext context)
    {
        Debug.Log("CHEATS: Next Round");
        //roundManager.NextRound();
    }
}
