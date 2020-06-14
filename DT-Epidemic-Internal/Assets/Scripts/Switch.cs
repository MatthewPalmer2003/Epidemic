using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Switch : MonoBehaviour
{
    [SerializeField]
    Sprite onSprite, offSprite;

    public bool isOn = true;

    void Start()
        
    {
        // Sets the switch to the on sprite
        gameObject.GetComponent<SpriteRenderer>().sprite = onSprite;
    }


    void OnTriggerEnter2D(Collider2D col)
        
    {
        if (!isOn)
        {
            // Sets the switch to the on sprite
            gameObject.GetComponent<SpriteRenderer>().sprite = onSprite;


            // Sets the isOn to true when triggered
            isOn = true;
        }

        else
        {
            // Sets the switch to the off sprite
            gameObject.GetComponent<SpriteRenderer>().sprite = offSprite;

            // Sets the isOn to false when triggered
            isOn = false;
        }
           
    }

    public void OnHitGround()
    {
        // Sets the switch to the on sprite
        gameObject.GetComponent<SpriteRenderer>().sprite = onSprite;

        // Sets the isOn to true when triggered
        isOn = true;
    }
}
