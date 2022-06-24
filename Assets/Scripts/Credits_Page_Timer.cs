using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits_Page_Timer : MonoBehaviour
{
    private void Update()
    {
        StartCoroutine(CountDown());
    }

    IEnumerator CountDown()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("Menu");
    }
}
