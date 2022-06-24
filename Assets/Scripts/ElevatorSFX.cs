using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorSFX : MonoBehaviour
{
    [SerializeField]
    private AudioSource ElevatorSoundEffects;
    [SerializeField]
    private AudioSource ElevatorDingEffect;

    public void ElevatorSound()
    {
        ElevatorSoundEffects.Play();
    }
    public void ElevatorDingSound()
    {
        ElevatorDingEffect.Play();
    }
}
