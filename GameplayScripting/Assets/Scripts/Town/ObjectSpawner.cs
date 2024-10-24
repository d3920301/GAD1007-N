/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
* Object Spawner                                                         *
* Manage Spawning objects as well as offering ways to interact with them *
* INTERACTABLE IS CURRENTLY NOT IMPLEMENTED                              *
* PLEASE PUT SPRITES IN THE SPRITE RENDER INSTEAD OF THE sprite VARIABLE *
* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
// The GameObject is a reference to the object in the scene, and the int is a reference to the interaction point.
// Put 0 if there is only 1 interaction point. If it does not matter where the interaction event was called from, then put 0.
public class InteractionEvent : UnityEvent<GameObject>
{
}

public class ObjectSpawner : MonoBehaviour
{
    public InteractionEvent m_InteractEvent;

    //[SerializeField] private Sprite sprite = null;

    private enum State {NonInteractable, Interactable, Pickup};
    [SerializeField] private State state= State.NonInteractable;
    //private bool canInteract = false;

    [SerializeField] private GameObject interactionTarget = null;
    [SerializeField] private int interactionPoint = 0;

    private void Awake()
    {
        //GetComponent<SpriteRenderer>().sprite = sprite;
    }

    private void Start()
    {
        m_InteractEvent ??= new InteractionEvent();

        if (state == State.NonInteractable)
        {
            GetComponent<BoxCollider2D>().isTrigger = false;
        }
        else
        {
            GetComponent<BoxCollider2D>().isTrigger = true;
        }


    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        switch (state)
        {
            case State.NonInteractable:
                break;
            case State.Interactable:
                //canInteract = true;
                break;
            case State.Pickup:
                Interact();
                break;
            default:
                Debug.LogWarning("Unknown State");
                break;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        //canInteract = false;
    }

    private void Interact()
    {
        //Debug.Log("Interacted!");

        m_InteractEvent.Invoke(interactionTarget);
    }
}
