using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartBeatTrigger : MonoBehaviour
{
    [SerializeField]
    private AudioClip heartbeatSFX;
    AudioSource audioSource;


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && audioSource.isPlaying == false)
        {
            audioSource.PlayOneShot(heartbeatSFX);
        }
    }
}
