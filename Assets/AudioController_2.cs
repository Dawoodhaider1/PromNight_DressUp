using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioController_2 : MonoBehaviour
{
    //AudioController AudioController_1;
    private void Awake()
    {
        GameObject[] music = GameObject.FindGameObjectsWithTag("GameMusic");
        if (music.Length > 1)
        {
            Destroy(this.gameObject);
        }
        else
        {  
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
