﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    [SerializeField]
    Sprite onSprite, offSprite;

    public bool isOn = false;

    void Start()
        
    {
        //Sets the switch to the off sprite
        gameObject.GetComponent<SpriteRenderer>().sprite = offSprite;
    }


    void OnTriggerEnter2D(Collider2D col)
        
    {
        if (!isOn)
        {
            //Sets the switch to the on sprite
            gameObject.GetComponent<SpriteRenderer>().sprite = onSprite;

            //Sets the isOn to true when triggered
            isOn = true;
        }

        else
        {
            //Sets the switch to the off sprite
            gameObject.GetComponent<SpriteRenderer>().sprite = offSprite;

            //Sets the isOn to false when triggered
            isOn = false;
        }
           
    }
}
