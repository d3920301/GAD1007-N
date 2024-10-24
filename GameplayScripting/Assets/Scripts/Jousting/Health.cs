using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public event Action OnDamageTaken;
    public event Action OnPlayerDied;
    public event Action OnEnemyDied;

    [SerializeField] public float maxHealth = 1.0f;
    public float currentHealth { get; private set; } = 1.0f;
    public float healthLastRound { get; private set; } = 1.0f;

    private void Awake()
    {
        currentHealth = maxHealth;
        healthLastRound = currentHealth;
    }

    // We need to tell GameInformation we exist so it knows when we die!
    private void State()
    {
        FindObjectOfType<GameInformation>();
    }

    public void TakeDamage(float damage)
    {
        healthLastRound = currentHealth;
        currentHealth -= damage;
        // Debug.Log(this.name + " took " + damage);
        // Debug.Log(this.name + " has " + currentHealth + " health left");
        
        OnDamageTaken();

        if (currentHealth <= 0 && gameObject.tag == "Player")
        {
            //Debug.Log("HEALTH: Player Died");
            OnPlayerDied();
        }
        if (currentHealth <= 0 && gameObject.tag == "Enemy")
        {
            OnEnemyDied();
        }
    }
}