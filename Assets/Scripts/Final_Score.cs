using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Final_Score : MonoBehaviour
{
    public Text Display_Score_Player;
    public Text Display_Score_Player_2;
    public Text Display_Score_Opponent;
    public Text Display_Score_Opponent_2;
    public static int F_Score_player = 0;
    public static int F_Score_Opponent = 0;

    public int scorePass_Opponent;
    public int scorePass_Player;


    void Start()
    {
        

        //Final Scores
        F_Score_player = (scorePass_Player );
        F_Score_Opponent = (scorePass_Opponent );

        Output();
        
    }

    public void Output()
    {
        if (F_Score_player == F_Score_Opponent)
        {
            F_Score_player += 1;
            Display_Score_Player.text = F_Score_player.ToString();
            Display_Score_Player_2.text = F_Score_player.ToString();
            Display_Score_Opponent.text = F_Score_Opponent.ToString();
            Display_Score_Opponent_2.text = F_Score_Opponent.ToString();
        }
        else
        {
            Display_Score_Player.text = F_Score_player.ToString();
            Display_Score_Player_2.text = F_Score_player.ToString();
            Display_Score_Opponent.text = F_Score_Opponent.ToString();
            Display_Score_Opponent_2.text = F_Score_Opponent.ToString();
        }
    }
}
