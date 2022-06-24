using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prison_Door_Slam : MonoBehaviour
{
    [SerializeField]
    private Animator DoorSlamAnim;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            DoorSlamAnim.SetTrigger("Slam");
        }
    }
}
