using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SplashScreen : MonoBehaviour
{
    public static int sceneNumber;
    void Start()
    {
        if(sceneNumber == 0)
        {
            StartCoroutine(ToMainMenu());
        }
    }

    IEnumerator ToMainMenu()
    {
        yield return new WaitForSeconds(5);
        sceneNumber = 1;
        SceneManager.LoadScene(1);
    }
}
