using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    public Text textDisplay;

    void Start()
    {
        textDisplay.text = "You ae the Prime Minister of New Zealand and your goal is to navigate " +
            "your country through a global pandemic. You have new arrivals who have unknowingly brought " +
            "the virus into your country. It is highly infectious. You must minimise the impact of the " +
            "virus on people's physical well-being while at the same time protecting the countrys economic well-being. " +
            "Keep your country your country from being overwhelmed by the virus, without causing economic chaos, " +
            "while an anti-virus is being developed.";
    }
}
