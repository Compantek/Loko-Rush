using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSelectCamera : MonoBehaviour
{
    [SerializeField] public GameObject ash;
    [SerializeField] public GameObject cyborg;
    [SerializeField] public GameObject kevin;
    [SerializeField] public GameObject roger;
    [SerializeField] public TMP_Text nameText;
    
    private int _playerIndex;

    private ArrayList _posX;
    private ArrayList _nameList;

    private void Start()
    {
        _playerIndex = 0;
        _posX = new ArrayList { ash, cyborg, kevin, roger };
        _nameList = new ArrayList { "Ash", "Cyborg", "Kevin", "Roger" };
    }

    private void Update()
    {
        var p = (GameObject)_posX[_playerIndex];
        transform.position = new Vector3(p.transform.position.x, transform.position.y, transform.position.z);

        nameText.text = (string)_nameList[_playerIndex];
    }

    public void MoveLeft() {
        if (_playerIndex == 0) {
            Debug.Log("Can't move left");
        } else {
            _playerIndex--;
            Debug.Log("Player index: " + _playerIndex);
            // this.transform.position.Set((float)_posX[_playerIndex], transform.position.y, transform.position.z);
            // transform.position = new Vector3(transform.position.x - 1000.0f, transform.position.y, transform.position.z);
        }
    }

    public void MoveRight() {
        if (_playerIndex == 3) {
            Debug.Log("Can't move right");
        } else {
            _playerIndex++;
            Debug.Log("Player index: " + _playerIndex);
            // this.transform.position.Set((float)_posX[_playerIndex], transform.position.y, transform.position.z);
            // transform.position = new Vector3(transform.position.x + 1000.0f, transform.position.y, transform.position.z);
        }
    }
}
