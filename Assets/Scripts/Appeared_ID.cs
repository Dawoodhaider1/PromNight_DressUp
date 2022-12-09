using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Appeared_ID : MonoBehaviour
{
    private int ID;
    public Text versusText;
    //Opponent_ID opponent;

    private void Awake()
    {
        ID = Opponent_ID.appeared_ID;
        versusText.text = ID.ToString();
    }
}
