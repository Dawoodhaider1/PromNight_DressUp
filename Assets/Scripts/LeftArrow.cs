using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeftArrow : MonoBehaviour
{
    public GameObject[] PurchaseButtons = new GameObject[4];
    public Button LeftButton;
    RightArrow rightArrow;

    public int CurrentOfferNumber_Left = 0;

    private void Start()
    {
        rightArrow = GameObject.Find("RightArrow").GetComponent<RightArrow>();
    }
    private void Update()
    {
        CurrentOfferNumber_Left = rightArrow.CurrentOfferNumber;
        //Debug.Log("Current Offer for left is: " + CurrentOfferNumber_Left);
    }
    public void PreviousButton()
    {
        rightArrow.CurrentOfferNumber--;
        CurrentOfferNumber_Left--;
        if (CurrentOfferNumber_Left == 3)
        {
            PurchaseButtons[CurrentOfferNumber_Left].SetActive(true);
            PurchaseButtons[CurrentOfferNumber_Left - 1].SetActive(false);
            PurchaseButtons[CurrentOfferNumber_Left - 2].SetActive(false);
            PurchaseButtons[CurrentOfferNumber_Left - 3].SetActive(false);
            CurrentOfferNumber_Left--;
        }
        else if (CurrentOfferNumber_Left == 2)
        {
            PurchaseButtons[CurrentOfferNumber_Left].SetActive(true);
            PurchaseButtons[CurrentOfferNumber_Left + 1].SetActive(false);
            PurchaseButtons[CurrentOfferNumber_Left - 1].SetActive(false);
            PurchaseButtons[CurrentOfferNumber_Left - 2].SetActive(false);
            CurrentOfferNumber_Left--;
        }
        else if (CurrentOfferNumber_Left == 1)
        {
            PurchaseButtons[CurrentOfferNumber_Left].SetActive(true);
            PurchaseButtons[CurrentOfferNumber_Left - 1].SetActive(false);
            PurchaseButtons[CurrentOfferNumber_Left + 1].SetActive(false);
            PurchaseButtons[CurrentOfferNumber_Left + 2].SetActive(false);
            CurrentOfferNumber_Left--;
        }
        else if (CurrentOfferNumber_Left == 0)
        {
            PurchaseButtons[CurrentOfferNumber_Left].SetActive(true);
            PurchaseButtons[CurrentOfferNumber_Left + 1].SetActive(false);
            PurchaseButtons[CurrentOfferNumber_Left + 2].SetActive(false);
            PurchaseButtons[CurrentOfferNumber_Left + 3].SetActive(false);
            CurrentOfferNumber_Left--;
        }
        else if (CurrentOfferNumber_Left < 0)
        {
            rightArrow.CurrentOfferNumber = 0;
        }
    }
}
