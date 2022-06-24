using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioSFX : MonoBehaviour
{
    [SerializeField]
    private AudioSource RadioWavesSFX;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            RadioWavesSFX.Play();
        }
    }
}
