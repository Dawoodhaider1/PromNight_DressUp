using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win_Loose : MonoBehaviour
{
    public GameObject WinScene;
    public GameObject LooseScene;
    public GameObject Opponent_Groom;
    public GameObject Score_Cards;

    private bool Final_Scores;

    private void Start()
    {
        StartCoroutine(ExampleCoroutine());
    }

    public void Win_Scene()
    {
        Score_Cards.SetActive(false);
        Opponent_Groom.SetActive(false);
        WinScene.SetActive(true);
    }

    public void Loose_Scene()
    {
        Score_Cards.SetActive(false);
        Opponent_Groom.SetActive(false);
        LooseScene.SetActive(true);
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(10);

        if (Final_Scores = (Final_Score.F_Score_player >= Final_Score.F_Score_Opponent))
        {
            Win_Scene();
            yield return new WaitForSeconds(4f);
        }
        else if (Final_Scores = (Final_Score.F_Score_player < Final_Score.F_Score_Opponent))
        {
            Loose_Scene();
            yield return new WaitForSeconds(4f);
        }
    }
}
