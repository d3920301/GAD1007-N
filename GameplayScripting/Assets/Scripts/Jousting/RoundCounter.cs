using TMPro;
using UnityEngine;

public class RoundCounter : MonoBehaviour
{
    public int currentRound = 0;

    private TextMeshProUGUI textMeshProUGUI;

    private void Awake()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    public void IncrementCounter()
    {
        currentRound++;
        textMeshProUGUI.text = currentRound.ToString();
    }
}
