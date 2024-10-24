/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
* COUNTDOWN TIMER                                          *
* Use this timer for round start only.                     *
* Unless you want to see the word "GO!" after it finishes? * 
* * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

using UnityEngine;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    TextMeshProUGUI text;

    private float currentTime = 0.0f;
    private bool timerActive = false;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        StartTimer(3);
    }

    public void StartTimer(float initialTime)
    {
        currentTime = initialTime;
        timerActive = true;
    }

    private void Update()
    {
        if (timerActive)
        {
            currentTime -= Time.deltaTime;
            // Add one to the current time so we dont see 0. (We dont see 4 dont worry)
            text.text = ((int)currentTime + 1).ToString();

            if (currentTime <= 0.0f)
            {
                text.text = "GO!";
                timerActive = false;
                currentTime = 0.0f;

                Invoke(nameof(HideCountdownText), 1);
            }
        }
    }

    private void HideCountdownText()
    {
        text.text = "";
    }
}