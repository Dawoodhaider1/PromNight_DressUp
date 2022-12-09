using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class opponentAvatar : MonoBehaviour
{
    public Image opponent;
    public Image oppflag;
    
    public Sprite[] avatar;
    public Sprite[] flag;

    public static int randIndex;
    bool doNow;

    void Start()
    {
        doNow = true;
        StartCoroutine(CloseNow());
    }
    
    IEnumerator CloseNow()
    {
        yield return new WaitForSeconds(2f);
        doNow = false;
    }
    
    void Update()
    {
        if (doNow)
        {
            randIndex = Random.Range(0, (avatar.Length - 1));
            opponent.sprite = avatar[randIndex];
            oppflag.sprite = flag[randIndex];
        }

    }
}
