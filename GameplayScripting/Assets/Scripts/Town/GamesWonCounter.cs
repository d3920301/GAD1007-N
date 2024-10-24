using UnityEngine;
using TMPro;

public class GamesWonCounter : MonoBehaviour
{
    private TextMeshProUGUI gamesWonText;

    private void Start()
    {
        gamesWonText = GetComponent<TextMeshProUGUI>();
        //Debug.Log(FindObjectOfType<GameInformation>().gamesWon);
        gamesWonText.text = "Games Won: " + FindObjectOfType<GameInformation>().gamesWon;
    }
}
