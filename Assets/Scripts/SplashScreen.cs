using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SplashScreen : MonoBehaviour
{
    public Slider loadingBar;
    void Start()
    {
        StartCoroutine(LoadingScene());
    }

    IEnumerator LoadingScene()
    {
        for(int i = 0; i <= 5; i++)
        {
            yield return new WaitForSeconds(1);
            loadingBar.value = i;
        }
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
    }
}
