using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hidden_Door : MonoBehaviour
{
    [SerializeField]
    private Animator HiddenDoorAnim;

    private bool HiddenDoorOpen = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && HiddenDoorOpen == false)
        {
            if(GameManager.Instance.HasKey == true)
            {
                HiddenDoorAnim.SetTrigger("OpenDoor");
                HiddenDoorOpen = true;
            }
        }
    }
}
