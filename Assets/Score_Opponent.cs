using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Opponent : MonoBehaviour
{
    public Text score_Opponent;
    //public Text score_Bottom;
    private int Opponent_Score;
    private Final_Score_Opponent score_Passing;

    public int Score_earned = 0;

    void Start()
    {
        score_Passing = FindObjectOfType<Final_Score_Opponent>();

        Opponent_Score = 0;
        ScoreText();
        Score_earned = (Opponent_Score + Score_earned);
        score_Passing.scorePass_Opponent = Score_earned;
    }

    public void ScoreText()
    {
        Opponent_Score = Random.Range(5, 10);
        score_Opponent.text = Opponent_Score.ToString();
        //score_Bottom.text = Player_Score.ToString();
    }
}
