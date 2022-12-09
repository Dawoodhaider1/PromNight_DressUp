using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public int Total_Coins;
    public Text coins_text;
    private CoinsEarned coins;

    void Start()
    {
        MainManager.Instance.LoadUserData();
        Total_Coins = MainManager.Instance.Coins;
        //MainManager.Instance.LoadUserData();
        SetCoins();
    }

    public void SetCoins()
    {
        coins_text.text = Total_Coins.ToString(); 
        MainManager.Instance.SaveUserData();
    }
}
