using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class useButton : MonoBehaviour
{
    public void buttonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void buttonClick2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void buttonClick3()
    {
        Screenshot.TakeScreenshot_Static(500, 500);
    }

    public void sliderValue()
    {
        changeZoom.changeValueStatic();
    }
}
