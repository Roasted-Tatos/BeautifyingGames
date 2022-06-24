using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whispers : MonoBehaviour
{
    [SerializeField]
    private AudioClip whipsers;

    private bool triggered = false;

    AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && triggered == false)
        {
            AudioSource.PlayClipAtPoint(whipsers, Camera.main.transform.position);
            triggered = true;
        }
    }
}
