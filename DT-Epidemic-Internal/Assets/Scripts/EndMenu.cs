using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EndMenu : MonoBehaviour
{
    public Text textDisplay;

    // Displays in a textbox on the screen "Game over!"
    void Start()
    {
        textDisplay.text = "Game over!";
    }

    // Loads the Main or first level of the game
    public void PlayAgain()
    {
        SceneManager.LoadScene("Main");
    }

    // Loads the Main Menu scene
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
}
