using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField]
    private AudioClip keySFX;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(keySFX,Camera.main.transform.position);
            GameManager.Instance.HasKey = true;
            Destroy(this.gameObject);
        }
    }
}
