using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadBody_Triggers : MonoBehaviour
{
    [SerializeField]
    private Animator tooClose;
    [SerializeField]
    private AudioSource monsterSound;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            tooClose.SetTrigger("TooClose");
            monsterSound.Play();
        }
    }
}
