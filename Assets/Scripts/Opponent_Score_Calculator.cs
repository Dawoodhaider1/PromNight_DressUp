using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Opponent_Score_Calculator : MonoBehaviour
{
    public Text O_ScoreCard_1;
    public Text O_ScoreCard_2;
    public Text O_ScoreCard_3;
    public Text O_ScoreCard_Final;

    public int score_1_O;
    public int score_2_O;
    public int score_3_O;
    public int score_Final_O;

    public void Awake()
    {
        score_1_O = Random.Range(5, 10);
        score_2_O = Random.Range(5, 10);
        score_3_O = Random.Range(5, 10);
        score_Final_O = (score_1_O + score_2_O + score_3_O) / 3;

        O_ScoreCard_1.text = score_1_O.ToString();
        O_ScoreCard_2.text = score_2_O.ToString();
        O_ScoreCard_3.text = score_3_O.ToString();
        O_ScoreCard_Final.text = score_Final_O.ToString();
        MainManager.Instance.Final_Score_Opponent = score_Final_O;
    }
}
