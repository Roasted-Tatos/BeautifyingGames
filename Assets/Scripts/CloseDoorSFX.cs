using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoorSFX : MonoBehaviour
{
    [SerializeField]
    private AudioSource closedSoundSFX;
    [SerializeField]
    private AudioSource openSoundSFX;

    public void OpenDoorSound()
    {
        openSoundSFX.Play();
    }
    public void CloseDoorSound()
    {
        closedSoundSFX.Play();
    }

}
