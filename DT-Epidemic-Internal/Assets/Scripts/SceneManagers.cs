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
        bool complete = true;
        foreach (Switch s in switches)
        {
            if (s.isOn)
            {
                complete = false;
            }

        }

        if (complete)
        {
            SceneManager.LoadScene(sceneToGoTo);
        }
    }
}
