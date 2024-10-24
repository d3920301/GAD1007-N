using UnityEngine;

public class HealthBar : MonoBehaviour
{
    SpriteMask spriteMask;
    Health healthComp;

    // Start is called before the first frame update
    void Start()
    {
        spriteMask = GetComponentInChildren<SpriteMask>();
        healthComp = GetComponentInParent<Health>();
    
        healthComp.OnDamageTaken += UpdateHealthBar;
    }

    private void UpdateHealthBar()
    {
        //spriteMask.transform.localScale = new Vector3(healthComp.currentHealth / healthComp.maxHealth, spriteMask.transform.localScale.y, spriteMask.transform.localScale.z);
        // Get difference betweem Max Health and Current Health. Divide diff by Max Health. Do local position -= Result 
        float diff = healthComp.healthLastRound - healthComp.currentHealth;
        float result = diff / healthComp.maxHealth;
        spriteMask.transform.localPosition = new Vector3(spriteMask.transform.localPosition.x - result, spriteMask.transform.localPosition.y, spriteMask.transform.localPosition.z);
    }
}
