using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hidden_DoorSFX : MonoBehaviour
{
    [SerializeField]
    private AudioSource HiddenSound;

    public void HiddenSoundEffect()
    {
        HiddenSound.Play();
    }
}
