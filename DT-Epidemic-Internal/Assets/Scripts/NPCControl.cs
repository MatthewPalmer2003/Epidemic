using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NPCControl : MonoBehaviour
{

    public Text npcHitText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //bool hasCompleted = true;

        //foreach (string s in strings)
        //{  

        //}
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        npcHitText.text = ("Press A or the left arrow key to move left.");

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            npcHitText.text = ("Press D or the right arrow key to move right");
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            npcHitText.text = ("Press the space bar, W or the up arrow key to jump");
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space))
        {
            npcHitText.text = ("Now use your knowledge to find the switch and then come back and see me whe you have successfully stopped the timer!");
        }




    }
}
