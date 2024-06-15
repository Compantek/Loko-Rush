using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MusicButton : MonoBehaviour
{
    [SerializeField] public GameObject musicGameObject;
    [SerializeField] public Button musicButtonToggle;
    [SerializeField] public TMP_Text musicButtonText;
    
    public void disableSound()
    {
        var audioSource = musicGameObject.GetComponent<AudioSource>();
        if (audioSource != null)
        {
            if (audioSource.isPlaying)
            {
                audioSource.Pause();
                musicButtonText.text = "OFF";
            }
            else
            {
                audioSource.Play();
                musicButtonText.text = "ON";
            }
        }
    }
}
