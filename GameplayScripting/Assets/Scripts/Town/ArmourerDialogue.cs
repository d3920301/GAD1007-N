using UnityEngine;

public class ArmourerDialogue : MonoBehaviour
{
    private Speak speak = null;

    [SerializeField] private bool canSpeak = true;

    // Start is called before the first frame update
    void Start()
    {
        speak = GetComponentInChildren<Speak>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && canSpeak)
        {
            Speak();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && canSpeak)
        {
            speak.HideText();
        }
    }

    private void Speak()
    {
        int randNum = Random.Range(0, 2);

        switch (randNum)
        {
            case 0:
                speak.GiveText("Pick your gear!");
                break;
            case 1:
                speak.GiveText("What gear do you want?");
                break;
            default:
                Debug.LogWarning("Unknown number");
                break;
        }
        speak.ShowText();


        return;
    }
}
