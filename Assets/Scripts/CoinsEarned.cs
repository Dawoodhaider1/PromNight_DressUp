using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsEarned : MonoBehaviour
{
    public Text score;
    public int x;

    public int Coins_earned;

    void Start()
    {
        x = 0;
        ScoreText();

        //x = (x + Coins_earned);
        Coins_earned = x + MainManager.Instance.Coins;

        MainManager.Instance.Coins = Coins_earned;
        MainManager.Instance.SaveUserData();
    }

    public void ScoreText()
    {
        x = Random.Range(150, 300);
        score.text = x.ToString();
    }
}
