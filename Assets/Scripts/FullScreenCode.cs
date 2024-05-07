using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FullScreemCode : MonoBehaviour
{
    public Toggle toggle;
    public TMP_Dropdown resolutionsDropDown;
    Resolution[] resolutions;
    // Start is called before the first frame update
    void Start()
    {
        if(Screen.fullScreen){
            toggle.isOn = true;
        }else{
            toggle.isOn = false;
        }
        ReviewResolution();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivFullScreen(bool value){
        Screen.fullScreen = value;
    }
    public void ReviewResolution(){
        resolutions = Screen.resolutions;
        resolutionsDropDown.ClearOptions();
        List<string> options = new List<string>();
        int currentResolution = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width +" x "+ resolutions[i].height;
            options.Add(option);

            if(Screen.fullScreen && resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height){
                currentResolution = i;
            }
        }

        resolutionsDropDown.AddOptions(options);
        resolutionsDropDown.value = currentResolution;
        resolutionsDropDown.RefreshShownValue();

        resolutionsDropDown.value = PlayerPrefs.GetInt("numberResolution",0);
    }
    public void ChangeResolution(int indexResolution){
        PlayerPrefs.SetInt("numberResolution",resolutionsDropDown.value);

        Resolution resolution = resolutions[indexResolution];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
}
