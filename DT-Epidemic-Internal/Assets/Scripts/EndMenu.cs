using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EndMenu : MonoBehaviour
{
    public Text textDisplay;

    void Start()
    {
        textDisplay.text = "Game over!";
    }


    public void PlayAgain()
    {
        SceneManager.LoadScene("Main");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
}
