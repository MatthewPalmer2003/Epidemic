using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountryHealth : MonoBehaviour
{
    public Slider slider;

    public Text sliderText;

    void Start()
    {
        sliderText.text = "Country Health";
    }

    public void SetMaxHealth(float health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(float health)
    {
        slider.value = health;
    }

    void Update()
    {
        if (slider.value <= 0)
        {
            SceneManager.LoadScene("YouLose");
        }

    }

}
