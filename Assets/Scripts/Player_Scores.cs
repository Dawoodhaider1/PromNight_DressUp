using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Scores : MonoBehaviour
{
    //Player_Score_Calculator player;
    //Opponent_Score_Calculator opponent;
    private Image x;
    public Animator animator_Models; //Animation controller for the Models after scores are displayed. 
    public Animator animator_Models_Opponent; //Animation controller for the Opponent Models after Player Models are disabled. 
    //public GameObject Models;
    public GameObject SubmitButton;
    public GameObject PlayerBackground;
    public GameObject OpponentBackground;

    public GameObject Models_Opponent;

    public GameObject ScoreCard_1;
    public GameObject ScoreCard_2;
    public GameObject ScoreCard_3;
    public GameObject ScoreCard_Final;

    public GameObject ScoreCard_1_Opponent;
    public GameObject ScoreCard_2_Opponent;
    public GameObject ScoreCard_3_Opponent;
    //public GameObject ScoreCard_Final_Opponent;

    public GameObject Winner;
    public GameObject Looser;

    private void Start()
    {
        //player = SubmitButton.GetComponent<Player_Score_Calculator>();
        //opponent = SubmitButton.GetComponent<Opponent_Score_Calculator>();

        x = SubmitButton.GetComponent<Image>();
        OnClick();
    }

    public void OnClick()
    {
        StartCoroutine(ScoreDelay());
    }

    IEnumerator ScoreDelay()
    {
        yield return new WaitForSeconds(9f);
        ScoreCard_1.SetActive(false);
        ScoreCard_2.SetActive(false);
        ScoreCard_3.SetActive(false);
        ScoreCard_Final.SetActive(false);

        //Models.SetActive(false);
        PlayerBackground.SetActive(false);
        OpponentBackground.SetActive(true);
        //yield return new WaitForSeconds(1f);
        Models_Opponent.SetActive(true);


        yield return new WaitForSeconds(9f);
        ScoreCard_1_Opponent.SetActive(false);
        ScoreCard_2_Opponent.SetActive(false);
        ScoreCard_3_Opponent.SetActive(false);
        //ScoreCard_Final_Opponent.SetActive(false);

        if (MainManager.Instance.Final_Score_Player >= MainManager.Instance.Final_Score_Opponent) // Win/Loose Condition...
        {
            Winner.SetActive(true);
        }
        else
        {
            Looser.SetActive(true);
        }
        
    }

    public void DisableImage()
    {
        x.enabled = false;
    }

    public void EnableAnimations()
    {
        animator_Models.enabled = true;
        animator_Models_Opponent.enabled = true;
    }
}
