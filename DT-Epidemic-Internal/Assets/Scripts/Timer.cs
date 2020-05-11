using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private Text uiText;

    [SerializeField]
    private float mainTimer;

    [SerializeField]
    Switch switchController;

    [SerializeField]
    bool startTimer = true;

    private float timer;
    private bool canCount = true;
    //private bool doOnce = false;
    //private bool stopTimer = true;


    // Start is called before the first frame update
    void Start()
    {
        timer = mainTimer;

        if (startTimer)
        {
            switchController.isOn = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 0.0f && canCount && switchController.isOn)
        {
            timer += Time.deltaTime;
            uiText.text = timer.ToString("F");
        }

        //else if(timer <= 0.0f && !doOnce)
        //{
        //    canCount = false;
        //    doOnce = true;
        //    uiText.text = "0.00";
        //    timer = 0.0f;
        //}

        //if (switchController.isOn == false)
        //{
        //    stopTimer = true;
        //    Debug.Log("Stop the timer");
        //}

        //else
        //{
        //    stopTimer = false;
        //    Debug.Log("Start the timer again");
        //}
    }

    //private void YouLose()
    //{

    //}
}
