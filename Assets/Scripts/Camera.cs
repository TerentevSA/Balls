using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    private Vector3 _playerPosition;
    private Transform _camera;

    private void Start()
    {
        _playerPosition = _player.transform.position;
        _camera = GetComponent<Transform>();
    }

    void Update()
    {
        _playerPosition = _player.transform.position;
        _camera.position = new Vector3(_playerPosition.x, _playerPosition.y + 40, _playerPosition.z - 80);
    }
}
