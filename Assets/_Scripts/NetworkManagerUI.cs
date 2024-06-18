using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class NetworkManagerUI : MonoBehaviour
{
    [SerializeField] private Button buttonServer;
    [SerializeField] private Button buttonHost;
    [SerializeField] private Button buttonClient;
    [SerializeField] private Button buttonPlay;

    private GameManager gameManager;

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();

        // buttonServer.onClick.AddListener(() =>
        // {
        //     NetworkManager.Singleton.StartServer();
        // });

        // buttonHost.onClick.AddListener(() =>
        // {
        //     NetworkManager.Singleton.StartHost();
        // });

        // buttonClient.onClick.AddListener(() =>
        // {
        //     NetworkManager.Singleton.StartClient();
        // });

        buttonPlay.onClick.AddListener(() =>
        {
            NetworkManager.Singleton.StartClient();
            gameManager.GetPlayer();
            gameManager.AssignPlayerPosition();
        });
    }
}
