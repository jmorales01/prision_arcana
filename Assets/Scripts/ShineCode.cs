using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShineCode : MonoBehaviour
{
    public Slider slider;
    public float sliderValue;
    public Image panelBrillo;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("shine",0.5f);
        panelBrillo.color = new Color(panelBrillo.color.r,panelBrillo.color.g,panelBrillo.color.b,slider.value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeSlider(float value){
        sliderValue = value;
        PlayerPrefs.SetFloat("shine",sliderValue);      // Save value shine in variable "shine" permanent
        panelBrillo.color = new Color(panelBrillo.color.r,panelBrillo.color.g,panelBrillo.color.b,slider.value);
    }
}
