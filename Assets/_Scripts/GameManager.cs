using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using Unity.Netcode;
using UnityEngine;

public class GameManager : NetworkBehaviour
{
    private GameObject player;
    private int playersCount = 1;
    private int connectedPlayersCount = 0;
    
    public Transform playerSpawnA;
    public Transform playerSpawnB;
    public Transform playerSpawnC;
    public Transform playerSpawnD;

    // Start is called before the first frame update
    void Start()
    {
        NetworkManager.Singleton.StartHost();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnNetworkSpawn()
    {
        GetPlayer();

        if (IsServer || IsHost)
        {
            connectedPlayersCount = NetworkManager.Singleton.ConnectedClients.Count;
            if (playersCount == connectedPlayersCount)
            {
                LauchParty();
            }
        }

        base.OnNetworkSpawn();
    }

    public void GetPlayer()
    {
        Debug.Log("Getting player");
        player = GameObject.FindWithTag("Player");
    }

    public void AssignPlayerPosition()
    {
      Debug.Log("Assign player position");
        player.transform.position = playerSpawnB.position;
    }

    public void LauchParty()
    {
        AssignPlayerPosition();
        Debug.Log("Party launched");
    }
}
