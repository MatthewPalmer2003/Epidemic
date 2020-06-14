using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{
    public Text textDisplay;

    void Start()
    {
        textDisplay.text = "Game Creator:" + "\n" + "Matthew Palmer" + "\n" + "\n" + "Client:" + "\n" + "Mark Palmer" +
            "\n" + "\n" + "Lost Relic Gaming youtube channel" + "\n" + "\n" + "Joshua Browne" + "\n" + "";
    }
}
