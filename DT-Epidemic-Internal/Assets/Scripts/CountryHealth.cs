using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountryHealth : MonoBehaviour
{
    public Slider slider;

    public Text sliderText;

    void Start()
    {
        sliderText.text = "Country Health";
    }

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }

}
