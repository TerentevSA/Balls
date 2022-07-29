using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeCoin : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<Player>(out Player player))
        {
            Destroy(gameObject);
            player.LevelUp();
        }
    }
}
