using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCanvas : MonoBehaviour
{
public GameObject CanvasObject;

    public void DisableCanvas() {
        CanvasObject.SetActive(false);
    }

    public void EnableCanvas() {
        CanvasObject.SetActive(true);
    }
}
