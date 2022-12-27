using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightArrow : MonoBehaviour
{
    public GameObject[] PurchaseButtons = new GameObject[4];
    public Button RigthButton;

    public int CurrentOfferNumber = 0;
    
    public void NextButton()
    {
        CurrentOfferNumber++;
        if (CurrentOfferNumber == 1)
        {
            PurchaseButtons[CurrentOfferNumber].SetActive(true);
            PurchaseButtons[CurrentOfferNumber + 1].SetActive(false);
            PurchaseButtons[CurrentOfferNumber + 2].SetActive(false);
            PurchaseButtons[CurrentOfferNumber - 1].SetActive(false);
            //CurrentOfferNumber++;
        }
        else if (CurrentOfferNumber == 2)
        {
            PurchaseButtons[CurrentOfferNumber].SetActive(true);
            PurchaseButtons[CurrentOfferNumber + 1].SetActive(false);
            PurchaseButtons[CurrentOfferNumber - 2].SetActive(false);
            PurchaseButtons[CurrentOfferNumber - 1].SetActive(false);
            //CurrentOfferNumber++;
        }
        else if (CurrentOfferNumber == 3)
        {
            PurchaseButtons[CurrentOfferNumber].SetActive(true);
            PurchaseButtons[CurrentOfferNumber - 1].SetActive(false);
            PurchaseButtons[CurrentOfferNumber - 2].SetActive(false);
            PurchaseButtons[CurrentOfferNumber - 3].SetActive(false);
            //CurrentOfferNumber++;
        }
        else if(CurrentOfferNumber > 3)
        {
            CurrentOfferNumber = 3;
        }
    }
}
