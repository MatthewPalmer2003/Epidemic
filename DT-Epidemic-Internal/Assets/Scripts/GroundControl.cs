using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundControl : MonoBehaviour
{

    //Used for the health bar
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


    private void OnTriggerEnter2D(Collider2D col)
    {
        TakeDamage(groundDamage);

        lastDamageTime = Time.time;

        foreach(Switch s in FindObjectsOfType<Switch>())
        {
            s.OnHitGround();
        }
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (lastDamageTime + timeBetweenHits < Time.time)
        {
            TakeDamage(groundDamage);

            lastDamageTime = Time.time;
        }
    }


    //Taking the players health and updating it so that they are taking damage
    void TakeDamage(float damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}
