using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    // Please don't re-arrange these entries. It will probably break all doors that are in the game :( Just add a value after the enum name.
    public enum DoorDestinations {Armoury = 20, NextRound = -20, Town = 0, Default = 0};

    [SerializeField] public DoorDestinations DoorLoc;
    [SerializeField] public DoorDestinations DoorDest;
    
    BoxCollider2D boxCollider2D = null;

    void Awake()
    {
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject[] dests = GameObject.FindGameObjectsWithTag("Door");
            foreach (GameObject dest in dests)
            {
                if ((dest.GetComponent<Door>().DoorLoc == DoorDest) && other.gameObject.GetComponent<TownPlayerMovement>().canTp) // If the location of the new door is equal to that of the current door dest
                {
                    other.transform.position = dest.transform.position;
                    //Debug.Log(other.transform.position);
                    //Debug.Log(dest.transform.position);

                    // Find main camera and offset it by the enum amount on the x axis
                    GameObject mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
                    mainCamera.transform.position = new Vector3((float)DoorDest, mainCamera.transform.position.y, mainCamera.transform.position.z);

                    other.gameObject.GetComponent<TownPlayerMovement>().TPCD(2);
                }
                else if (DoorDest == DoorDestinations.Town && other.gameObject.GetComponent<TownPlayerMovement>().canTp)
                {
                    other.transform.position = new Vector2(0, 0);
                    // Find main camera and offset it by the enum amount on the x axis
                    GameObject mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
                    mainCamera.transform.position = new Vector3((float)DoorDest, mainCamera.transform.position.y, mainCamera.transform.position.z);
                    other.gameObject.GetComponent<TownPlayerMovement>().TPCD(2);
                }
                else if (DoorDest == DoorDestinations.NextRound)
                {
                    SceneManager.LoadScene(1);
                }
            }
        }
    }
}

