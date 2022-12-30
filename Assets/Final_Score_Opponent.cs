using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Final_Score_Opponent : MonoBehaviour
{
    public Text Display_Score_Opponent;
    //public Text Display_Score_Player_2;
    public static int F_Score_Opponent = 0;
    public int scorePass_Opponent;


    void Start()
    {
        //Final Scores
        F_Score_Opponent = (scorePass_Opponent / 3);
        MainManager.Instance.Final_Score_Opponent = F_Score_Opponent;
        Output();

    }

    public void Output()
    {
        Display_Score_Opponent.text = F_Score_Opponent.ToString();
        //Display_Score_Player_2.text = F_Score_player.ToString();
    }
}
