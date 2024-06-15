using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SoundButton : MonoBehaviour
{
    [SerializeField] public GameObject soundAudioSourceGameObject;
    [SerializeField] public TMP_Text soundToggleButtonText;
    
    public void DisableSounds()
    {
        var audioSource = soundAudioSourceGameObject.GetComponent<AudioSource>();
        
        if (audioSource.volume > 0.0f)
        {
            audioSource.volume = 0.0f;
            soundToggleButtonText.text = "OFF";
        }
        else
        {
            audioSource.volume = 100.0f;
            soundToggleButtonText.text = "ON";
        }
    }
}
