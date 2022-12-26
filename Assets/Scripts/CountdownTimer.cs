using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    LevelManager levelManager;
    public GameObject LoosePanel;
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
            LoosePanel.SetActive(true);
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
