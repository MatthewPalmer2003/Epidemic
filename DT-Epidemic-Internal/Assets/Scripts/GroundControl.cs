using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundControl : MonoBehaviour
{

    // Used for the health bar
    public int maxHealth = 100;

    public float currentHealth;

    public CountryHealth healthBar;

    float lastDamageTime;

    [SerializeField]
    int groundDamage;

    [SerializeField]
    float timeBetweenHits;

    
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Detects when the switch has been set to off and stops taking damage from the player
    private void OnTriggerEnter2D(Collider2D col)
    {
        TakeDamage(groundDamage);

        lastDamageTime = Time.time;

        // Detects when the player hits the ground and resets the switches to their original state
        foreach(Switch s in FindObjectsOfType<Switch>())
        {
            s.OnHitGround();
        }
    }

    // Damages the player when they are on the base ground level 
    private void OnTriggerStay2D(Collider2D col)
    {
        if (lastDamageTime + timeBetweenHits < Time.time)
        {
            TakeDamage(groundDamage);

            // This sets a time between the extra damage that is taken from the player when they are on the ground level
            lastDamageTime = Time.time;
        }
    }


    // Taking the players health and updating it so that they are taking damage
    void TakeDamage(float damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}
