/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
* Speak script is a prefab and should be called from other scripts *
* Speech bubble sprite renderer is always invisible by default     *
* Don't forget to re-enable it!                                    * 
* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

using UnityEngine;
using TMPro;

public class Speak : MonoBehaviour
{
    [SerializeReference] GameObject speechBubble = null;
    private TextMeshProUGUI speechBubbleText = null;

    private void Awake()
    {
        // Get reference to SpeechBubbleText
        speechBubbleText = GetComponentInChildren<TextMeshProUGUI>();
    }

    public void ShowText()
    {
        speechBubble.GetComponent<SpriteRenderer>().enabled = true;
        // Apparently disabling the canvas doesn't hide text ...
        speechBubble.GetComponentInChildren<Canvas>().enabled = true;
        speechBubbleText.enabled = true;
    }

    public void ShowText(float delay = 1.0f)
    {
        Invoke(nameof(ShowText), delay);
    }

    public void HideText()
    {
        speechBubble.GetComponent<SpriteRenderer>().enabled = false;
        speechBubble.GetComponentInChildren<Canvas>().enabled = false;
        speechBubbleText.enabled = false;
    }

    public void HideText(float delay = 1.0f)
    {
        Invoke(nameof(HideText), delay);
    }

    public void GiveText(string text)
    {
        speechBubbleText.text = text;
    }
}
