using UnityEngine;

public class GearHandler : MonoBehaviour
{
    public static void GiveStrength()
    {
        //Debug.Log("Giving Strength");
        GameInformation.playerEquipment = Armoury.RPS.Strength;
        FindObjectOfType<CurrentGearGetter>().SetCurrentGearText();
    }
    public void GiveAgility()
    {
        GameInformation.playerEquipment = Armoury.RPS.Agility;
        FindObjectOfType<CurrentGearGetter>().SetCurrentGearText();
    }
    public void GiveEndurance()
    {
        GameInformation.playerEquipment = Armoury.RPS.Endurance;
        FindObjectOfType<CurrentGearGetter>().SetCurrentGearText();
    }

    private static void GearChanged()
    {
        if (FindAnyObjectByType<CurrentGearGetter>())
        {
            FindAnyObjectByType<CurrentGearGetter>().SetCurrentGearText();
        }
    }
}
