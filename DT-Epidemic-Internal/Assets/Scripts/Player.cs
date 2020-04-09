﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;

    public int currentHealth;

    public CountryHealth healthBar;

    //[SerializeField]
    PlayerMovement playerMovement;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        playerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        /*The below code was used to test if the health bar would function,
         ie go down when the player is touching the ground in this case */

        //if (playerMovement.isGrounded)
        //{
        //    playerMovement.isGrounded = true;
        //    TakeDamage(1);
        //}

        //if (Input.GetKeyDown(KeyCode.A) || (Input.GetKeyDown(KeyCode.RightArrow)))
        //{
        //    TakeDamage(1);
        //}

        //else if (Input.GetKeyDown(KeyCode.D) || (Input.GetKeyDown(KeyCode.LeftArrow)))
        //{
        //    TakeDamage(1);
        //}

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    TakeDamage(50000);
        //}
    }

    void TakeDamage(int damage)
    {
        //currentHealth -= damage;

        //healthBar.SetHealth(currentHealth);
    }
}
