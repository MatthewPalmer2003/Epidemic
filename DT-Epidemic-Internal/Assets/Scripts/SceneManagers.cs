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
        //Detects when the switch has been hit but doesn't change scene 
        bool complete = true;
        foreach (Switch s in switches)
        {
            if (s.isOn)
            {
                complete = false;
            }

        }

        //Detects when all of teh switches have been stopped and moves to the scene set in the unity inspector
        if (complete)
        {
            SceneManager.LoadScene(sceneToGoTo);
        }
    }
}
