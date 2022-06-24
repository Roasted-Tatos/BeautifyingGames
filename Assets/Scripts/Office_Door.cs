using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Office_Door : MonoBehaviour
{
    [SerializeField]
    private Animator OpenDoorAnim;

    private bool SoundSFX = false;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && SoundSFX == false)
        {
            OpenDoorAnim.SetTrigger("OpenDoor");
            SoundSFX = true;
            StartCoroutine(SoundSFXCountdown());
        }
    }

    IEnumerator SoundSFXCountdown()
    {
        yield return new WaitForSeconds(5);
        SoundSFX = false;
    }
}
