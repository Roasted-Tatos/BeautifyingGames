using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator_Door : MonoBehaviour
{
    [SerializeField]
    private Animator ElevatorDoor;

    private bool OpenDoor = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && OpenDoor == false)
        {
            ElevatorDoor.SetTrigger("OpenDoor");
            OpenDoor = true;
            StartCoroutine(OpenDoorCounter());
        }
    }

    IEnumerator OpenDoorCounter()
    {
        yield return new WaitForSeconds(5);
        OpenDoor = false;
    }
}
