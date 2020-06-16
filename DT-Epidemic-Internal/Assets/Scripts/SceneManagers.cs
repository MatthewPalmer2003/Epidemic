using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagers : MonoBehaviour
{
    [SerializeField]
    Switch[] switches;

    [SerializeField]
    string sceneToGoTo;


    // Start is called before the first frame update
    void Start()
    {
        switches = FindObjectsOfType<Switch>();
    }

    // Update is called once per frame
    void Update()
    {

        // Detects when the switch has been hit but doesn't change scene 
        bool complete = true;
        foreach (Switch s in switches)
        {
            if (s.isOn)
            {
                complete = false;
            }

        }

        // When all of the switches have been stopped. It runs the complete scene when it's true,
        // then it moves to the scene set in the unity inspector
        if (complete)
        {
            SceneManager.LoadScene(sceneToGoTo);
        }
    }
}
