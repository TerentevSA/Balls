using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform _transform;

    private void Start()
    {
        _transform = GetComponent<Transform>();
    }

    public void LevelUp()
    {
        _transform.localScale = new Vector3(_transform.localScale.x + 3, _transform.localScale.y + 3, _transform.localScale.z + 3);
    }
}
