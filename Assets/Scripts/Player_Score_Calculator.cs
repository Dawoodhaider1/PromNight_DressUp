using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Score_Calculator : MonoBehaviour
{
    Opponent_Score_Calculator opponent;
    public GameObject CurrentGameObject;
    public Text P_ScoreCard_1;
    public Text P_ScoreCard_2;
    public Text P_ScoreCard_3;
    public Text P_ScoreCard_Final;

    public int score_1;
    public int score_2;
    public int score_3;
    public int score_Final;

    private void Start()
    {
        opponent = CurrentGameObject.GetComponent<Opponent_Score_Calculator>();
    }

    public void Scoring()
    {
        score_1 = Random.Range(5, 10);
        score_2 = Random.Range(5, 10);
        score_3 = Random.Range(5, 10);
        score_Final = (score_1 + score_2 + score_3) / 3;

        P_ScoreCard_1.text = score_1.ToString();
        P_ScoreCard_2.text = score_2.ToString();
        P_ScoreCard_3.text = score_3.ToString();
        if (MainManager.Instance.Final_Score_Opponent == score_Final)
        {
            score_Final++;
        }
        P_ScoreCard_Final.text = score_Final.ToString();

        MainManager.Instance.Final_Score_Player = score_Final;
    }
}
