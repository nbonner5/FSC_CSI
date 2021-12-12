using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeZoom : MonoBehaviour
{
    private static changeZoom instance;
    private Slider mySlider;
    private Camera myCamera;
    
    private void Awake() {
        instance = this;
        myCamera = gameObject.GetComponent<Camera>();
        mySlider = gameObject.GetComponent<Slider>();
    }
    
    private void changeValue()
    {
        if (mySlider.value == 0.0)
        {
            myCamera.fieldOfView = 40.0f;
        }
        else if (mySlider.value > 0.0 && mySlider.value < 0.250)
        {
            myCamera.fieldOfView = 50.0f;
        }
        else if (mySlider.value >= 0.250 && mySlider.value < 0.500)
        {
            myCamera.fieldOfView = 60.0f;
        }
        else if (mySlider.value >= 0.500 && mySlider.value < 0.750)
        {
            myCamera.fieldOfView = 70.0f;
        }
        else if (mySlider.value >= 0.750 && mySlider.value < 1.0)
        {
            myCamera.fieldOfView = 80.0f;
        }
        else if (mySlider.value == 1.0)
        {
            myCamera.fieldOfView = 90.0f;
        }
    }

    public static void changeValueStatic() {
        instance.changeValue();
    }
}