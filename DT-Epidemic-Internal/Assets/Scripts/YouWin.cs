using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class YouWin : MonoBehaviour
{
    public Text textDisplay;

    // Displays in a textbox on the screen "Congratulations, You have successfully kept your country running through this pandemic!"
    void Start()
    {
        textDisplay.text = "Congratulations, You have successfully kept your country running through this pandemic!";
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
