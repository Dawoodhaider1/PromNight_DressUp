using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Opponent_ID : MonoBehaviour
{
    private int id;
    public static int appeared_ID;
    public Text playerID;
    private void Awake()
    {
        id = Random.Range(1000, 9999);
        playerID.text = id.ToString();
        appeared_ID = id;
    }
}
