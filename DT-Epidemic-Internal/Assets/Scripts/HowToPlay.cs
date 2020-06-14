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
        textDisplay.text = "To move left, press the left arrowkey or A. To move right, press the right arrowkey or D. To jump, press the space bar, the up arrowkey or W." + "\n"
            + "\n" + "The Objective of the game is to turn on/off switches to keep your country healthy.";
    }

}
