using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HowToPlay : MonoBehaviour
{
    public Text textDisplay;

    void Start()
    {
        textDisplay.text = "To move left, press the left arrowkey. To move right, press the right arrowkey. To jump, press the space bar or the up arrowkey." + "\n"
            + "\n" + "The Objective of the game is to turn on/off switches to keep your country healthy.";
    }

}
