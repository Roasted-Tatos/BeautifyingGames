using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrisonDoor_SFX : MonoBehaviour
{
    [SerializeField]
    private AudioSource prisonDoorSFX;
    [SerializeField]
    private AudioSource prisnonSlamSFX;

    public void PrisonDoorSoundEffect()
    {
        prisonDoorSFX.Play();
    }

    public void PrisonDoorSlamSFX()
    {
        prisnonSlamSFX.Play();
    }
}
