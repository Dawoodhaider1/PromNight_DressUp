using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConscentScene : MonoBehaviour
{
    public GameObject panel;
    void Start()
    {
        if(PlayerPrefs.HasKey("LinkTrue"))
        {
            SceneManager.LoadScene("1_SplashScreen");
        }
        else
        {
            panel.SetActive(true);
        }
    }

    public void Accept()
    {
        PlayerPrefs.SetInt("LinkTrue", 1);
        SceneManager.LoadScene("1_SplashScreen");
    }

    public void PrivacyLink()
    {
        Application.OpenURL("https://justgamesstudio.wpcomstaging.com/home/policy/");
    }
}
