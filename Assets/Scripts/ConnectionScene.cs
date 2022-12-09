using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConnectionScene : MonoBehaviour
{
    public GameObject NextPanel;
    public GameObject connection_scene;
    private int animation_time = 5;

    void Start()
    {
        StartCoroutine(ToConnectionScene());
    }

    IEnumerator ToConnectionScene()
    {
        yield return new WaitForSeconds(animation_time);
        connection_scene.SetActive(false);
        NextPanel.SetActive(true);
    }
}
