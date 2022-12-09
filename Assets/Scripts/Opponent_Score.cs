using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Opponent_Score : MonoBehaviour
{
    public Text score_Opponent;
    public Text score_Bottom_2;
    private int Opponent_score;
    public Final_Score Score_Passing;

    public int Score_earned_Opponent = 0;

    void Start()
    {
        Score_Passing = FindObjectOfType<Final_Score>();
        
        Opponent_score = 0;
        ScoreText_Opponent();
        Score_earned_Opponent = (Opponent_score + Score_earned_Opponent);
        Score_Passing.scorePass_Opponent = Score_earned_Opponent;
    }

    public void ScoreText_Opponent()
    {
        Opponent_score = Random.Range(5, 10);
        score_Opponent.text = Opponent_score.ToString();
        score_Bottom_2.text = Opponent_score.ToString();
    }
}
