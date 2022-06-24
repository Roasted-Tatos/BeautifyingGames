using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prison_Door : MonoBehaviour
{
    [SerializeField]
    private Animator PrisonDoorAnim;

    private bool DoorCanOpen = true;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && DoorCanOpen == true)
        {
            PrisonDoorAnim.SetTrigger("OpenDoor");
            DoorCanOpen = false;
            StartCoroutine(DoorCountdown());
        }
    }

    IEnumerator DoorCountdown()
    {
        yield return new WaitForSeconds(5);
        DoorCanOpen = true;
    }
}
