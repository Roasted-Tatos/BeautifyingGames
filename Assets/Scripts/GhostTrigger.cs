using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostTrigger : MonoBehaviour
{
    [SerializeField]
    private AudioClip ghostSFX;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            StartCoroutine(GhostDisappearCountDown());
        }
    }

    IEnumerator GhostDisappearCountDown()
    {
        AudioSource.PlayClipAtPoint(ghostSFX,Camera.main.transform.position);
        yield return new WaitForSeconds(1f);
        Destroy(this.gameObject);
    }
}
