using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlHead : MonoBehaviour
{
    [SerializeField]
    private AudioClip ghostScreech;

    AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            StartCoroutine(CountdownTimer());
        }
    }

    IEnumerator CountdownTimer()
    {
        AudioSource.PlayClipAtPoint(ghostScreech, Camera.main.transform.position);
        yield return new WaitForSeconds(0.8f);
        Destroy(this.gameObject);
    }
}
