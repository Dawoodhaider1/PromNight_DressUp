using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Appeared_ID_Player : MonoBehaviour
{
    private int ID;
    public Text versusText;
    //Opponent_ID opponent;

    private void Awake()
    {
        ID = Player_ID.appeared_ID_Player;
        versusText.text = ID.ToString();
    }
}
