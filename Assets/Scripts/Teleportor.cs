using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportor : MonoBehaviour
{
    [SerializeField]
    private PlayerMovement player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            player.teleportingPosition();
            GameManager.Instance.TotalRoundsCounter();
        }
    }
}
