using UnityEngine;

public class KingVic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Kings speach
        Speak speakComp = GetComponent<Speak>();
        speakComp.GiveText("Congratulations!");
        speakComp.ShowText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
