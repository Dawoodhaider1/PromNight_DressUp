using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score_Player;
    public Text score_Bottom;
    private int Player_Score;
    public Final_Score score_Passing;

    public int Score_earned = 0;

    void Start()
    {
        score_Passing = FindObjectOfType<Final_Score>();

        Player_Score = 0;
        ScoreText();
        Score_earned = (Player_Score + Score_earned);
        score_Passing.scorePass_Player = Score_earned;
    }

    public void ScoreText()
    {
        Player_Score = Random.Range(5, 10);
        score_Player.text = Player_Score.ToString();
        score_Bottom.text = Player_Score.ToString();
    }
}
