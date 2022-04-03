using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fuelbar : MonoBehaviour
{
    public Slider Slider;
    public PlayerController pc;
    public Gradient gradient;
    public Image fill;


     void Start()
    {
        initialize(pc.maxfuel, pc.fuel);
    }

     void Update()
    {
        SetValue(pc.fuel);
        setmaxvalue(pc.maxfuel, pc.fuel);
    }
     void SetValue(float fuel)
    {
        Slider.value = fuel;
        fill.color = gradient.Evaluate(Slider.normalizedValue);
    }
    void initialize(float maxfuel , float fuel)
    {
        Slider.maxValue = maxfuel;
        Slider.value = fuel;
        fill.color = gradient.Evaluate(1f);
    }
    void setmaxvalue(float maxfuel, float fuel)
    {
        Slider.maxValue = maxfuel;
    }

}