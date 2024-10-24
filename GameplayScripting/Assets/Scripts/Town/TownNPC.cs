using UnityEngine;

public class TownNPC : MonoBehaviour
{
    private Speak speak = null;

    [SerializeField] private bool canSpeak = false;
    [SerializeField] private Vector2 randNumRange = new Vector2(3.0f, 6.0f);
    private float randBreak = 3.0f;


    // Start is called before the first frame update
    void Start()
    {
        speak = GetComponentInChildren<Speak>();

        randBreak = Random.Range(randNumRange.x, randNumRange.y);

        if (canSpeak)
        {
            Invoke(nameof(Speak), randBreak);
        }
    }

    private void Speak()
    {
        float randDelayCurrText = Random.Range(1, 3);
        float randDelayNextText = Random.Range(5, 7);
        int randNum = Random.Range(0, 1);
        
        switch (GameInformation.CurrentEnemy)
        {
            case GameInformation.Enemy.Enemy1:
                switch (randNum)
                {
                    case 0:
                        speak.GiveText("I heard the next opponent is very strong...");
                        break;
                    default:
                        Debug.LogWarning("Random Number out of range");
                        break;
                }
                break;
            case GameInformation.Enemy.Enemy2:
                switch (randNum)
                {
                    case 0:
                        speak.GiveText("I heard the next opponent is very agile...");
                        break;
                    default:
                        Debug.LogWarning("Random Number out of range");
                        break;
                }
                break;
            case GameInformation.Enemy.Enemy3:
                switch (randNum)
                {
                    case 0:
                        speak.GiveText("I heard the next opponent is very endurant...");
                        break;
                    default:
                        Debug.LogWarning("Random Number out of range");
                        break;
                }
                break;
            default:
                Debug.LogWarning("Unknown enemy");
                break;
        }

        speak.ShowText();
        speak.HideText(randDelayCurrText);
        Invoke(nameof(Speak), randDelayNextText);
    }
}
