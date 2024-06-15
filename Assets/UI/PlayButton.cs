using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    [SerializeField] public TMP_Text playerNameText;

    public void LaunchGame()
    {
        StaticSceneManager.playerName = playerNameText.text;
        SceneManager.LoadScene("TestMap");
    }
}
