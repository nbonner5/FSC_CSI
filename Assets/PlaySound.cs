using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PlaySound : MonoBehaviour
{
    public AudioClip selectEnterSound;    
    public void PlaySelectEnterSound() {
        if(selectEnterSound != null) {
            AudioSource.PlayClipAtPoint(selectEnterSound, transform.position);
        }
    }
}