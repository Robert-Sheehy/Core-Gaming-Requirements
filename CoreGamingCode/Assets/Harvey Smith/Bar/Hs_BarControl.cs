using System;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class Hs_BarControl : MonoBehaviour
{
    public Image FillImage;
    public Slider slider;

    private void Start()
    {

    }

    void Update()
    {
        BarColourChange();
    }


    public void BarColourChange()
    {
        int fullHealth = 90;
        int mediumHealth = 80;
        int lowHealth = 40;
        float percentage = slider.value;
        if (percentage >= fullHealth)
        {
            FillImage.color = Color.green;

        }

        if (percentage < fullHealth && percentage > lowHealth)
        {
            FillImage.color = Color.yellow;

        }

        if (percentage <= lowHealth)
        {
            FillImage.color = Color.red;

        }


    }
}

