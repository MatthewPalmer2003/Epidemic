using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class YouWin : MonoBehaviour
{
    public Text textDisplay;

    void Start()
    {
        textDisplay.text = "Congratulations, You have successfully kept your country running through this pandemic!";
    }


    public void PlayAgain()
    {
        SceneManager.LoadScene("MainMenu");
    }


}
