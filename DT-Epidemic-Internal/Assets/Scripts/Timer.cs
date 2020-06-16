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

    public GroundControl groundControl;


    // Start is called before the first frame update
    void Start()
    {
        timer = mainTimer;

        // Starts the timer if switch is set to on which it is by default.
        if (startTimer)
        {
            switchController.isOn = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Control for the timers in the top right corner of the screen.
        // They only run when the switch is on and pause when they turn off.
        if (timer >= 0.0f && switchController.isOn)
        {
            timer += Time.deltaTime;
            uiText.text = timer.ToString("F");
            TakeDamage(Time.deltaTime);
        }

    }

    // Updates the damage to the player
    void TakeDamage(float damage)
    {
        groundControl.currentHealth -= damage;

        groundControl.healthBar.SetHealth(groundControl.currentHealth);
    }

}
