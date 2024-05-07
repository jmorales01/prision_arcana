using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CalityCode : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public int quality;
    // Start is called before the first frame update
    void Start()
    {
        quality = PlayerPrefs.GetInt("numberQuality",4);
        dropdown.value = quality;
        AdjustQuality();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AdjustQuality(){
        QualitySettings.SetQualityLevel(dropdown.value);
        PlayerPrefs.SetInt("numberQuality",dropdown.value);
        quality = dropdown.value;
    }
}
