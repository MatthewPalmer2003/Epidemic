using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    // private bool canCount = true;
    // private bool doOnce = false;
    // private bool stopTimer = true;

    public GroundControl groundControl;


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
        if (timer >= 0.0f && switchController.isOn)
        {
            timer += Time.deltaTime;
            uiText.text = timer.ToString("F");
            TakeDamage(Time.deltaTime);
        }

        // if (timer <= 99.99f && switchController.isOn)
        // {
        //    SceneManager.LoadScene("Level2");
        // }



        // else if(timer <= 0.0f && !doOnce)
        // {
        //    canCount = false;
        //    doOnce = true;
        //    uiText.text = "0.00";
        //    timer = 0.0f;
        // }

        // if (switchController.isOn == false)
        // {
        //    stopTimer = true;
        //    Debug.Log("Stop the timer");
        // }

        // else
        // {
        //    stopTimer = false;
        //    Debug.Log("Start the timer again");
        // }
    }


    void TakeDamage(float damage)
    {
        groundControl.currentHealth -= damage;

        groundControl.healthBar.SetHealth(groundControl.currentHealth);
    }

    // private void YouLose()
    // {

    // }
}
