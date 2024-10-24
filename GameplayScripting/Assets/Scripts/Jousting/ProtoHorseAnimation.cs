using UnityEngine;

public class ProtoHorseAnimation : MonoBehaviour
{
    Animator animator;
    [SerializeField] GameObject character;
    PlayerMovement charMoveScript;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        charMoveScript = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.speed = charMoveScript.GetVelocity();
    }
}
