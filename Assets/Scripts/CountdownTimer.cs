using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    LevelManager levelManager;
    float CurrentTime = 0f;
    private float StartingTime = 120f;

    public Text CountdownText;
    public GameObject Comparison_Panel;

    void Start()
    {
        CurrentTime = StartingTime;
    }

    int Update()
    {
        if(Comparison_Panel.activeSelf == true)
        {
            goto next;
        }
        else if(CurrentTime <= 0)
        {
            CurrentTime = 0;
            GameObject.FindObjectOfType<LevelManager>().LoadRequest("Loose");
        }
        else
        {
            CurrentTime -= 1 * Time.deltaTime;
            CountdownText.text = CurrentTime.ToString("0");
        }
    next:
        return 0;
    }
}
