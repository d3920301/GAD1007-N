using UnityEngine;
using TMPro;

public class CurrentGearGetter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SetCurrentGearText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string GetCurrentGear()
    {
        Armoury.RPS currEquipment = GameInformation.playerEquipment;

        switch (currEquipment)
        {
            case Armoury.RPS.Strength:
                return "Strength";
            case Armoury.RPS.Agility:
                return "Agility";
            case Armoury.RPS.Endurance:
                return "Endurance";
            default:
                Debug.LogWarning("Unknown equipment");
                return "UNKNOWN EQUIPMENT";
        }
    }

    public void SetCurrentGearText()
    {
        GetComponent<TextMeshProUGUI>().text = "Current Gear: " + GetCurrentGear();
    }
}
