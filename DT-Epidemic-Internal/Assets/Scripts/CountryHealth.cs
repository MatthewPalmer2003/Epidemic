using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountryHealth : MonoBehaviour
{
    public Slider slider;

    public Text sliderText;


    //Sets the text inside the textbox for the healthbar in the top left corner to "Country Health"
    //This could be set inside unity without any code but I chose to code it in.
    void Start()
    {
        sliderText.text = "Country Health";
    }

    //This sets sliders highest value to be equal to the health; and also sets the slider value to be equal to the health.
    //It is important to set the slider value to be equal to the health so that when the health goes down so does the slider value.
    public void SetMaxHealth(float health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    //Sets the slider value to be equal to the health.
    public void SetHealth(float health)
    {
        slider.value = health;
    }

    //This is checking to see if the value that the slider is at and is being displayed is less than or equal to zero and if it is then it will load the you lose scene.
    void Update()
    {
        if (slider.value <= 0)
        {
            SceneManager.LoadScene("YouLose");
        }

    }

}
