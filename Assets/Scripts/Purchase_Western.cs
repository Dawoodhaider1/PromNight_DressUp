using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Purchase_Western : MonoBehaviour
{
    public int price;
    public GameObject priceTag;
    public GameObject dress;
    public GameObject store;
    public Text Remaining_Coins;

    private int selected;
    private int side_button_number;

    public void OnMouseDown()
    {
        Button button = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
        selected = MainManager.Instance.item;
        side_button_number = MainManager.Instance.side_button_number;
        Debug.Log("The selected Item is:" + selected);

        //Male Model
        if (priceTag.activeSelf == true && MainManager.Instance.Purchased_Shirts[selected - 10] == 0 && side_button_number == 0)
        {
            if (MainManager.Instance.Coins >= price)
            {
                MainManager.Instance.Coins = MainManager.Instance.Coins - price;
                MainManager.Instance.Purchased_Shirts[selected - 10] = selected;
                priceTag.SetActive(false);

                Debug.Log("Price Tag Set to inactive...");
                Remaining_Coins.text = MainManager.Instance.Coins.ToString();
                dress.SetActive(true);
                MainManager.Instance.SaveUserData();
            }
            else
            {
                Debug.Log("Insufficient Money For this purchase");
                dress.SetActive(false);
                store.SetActive(true);
            }
        }

        else if (priceTag.activeSelf == true && MainManager.Instance.Purchased_Pants[selected - 10] == 0 && side_button_number == 1)
        {
            if (MainManager.Instance.Coins >= price)
            {
                MainManager.Instance.Coins = MainManager.Instance.Coins - price;
                MainManager.Instance.Purchased_Pants[selected - 10] = selected;
                priceTag.SetActive(false);

                Debug.Log("Price Tag Set to inactive...");
                Remaining_Coins.text = MainManager.Instance.Coins.ToString();
                dress.SetActive(true);
                MainManager.Instance.SaveUserData();
            }
            else
            {
                Debug.Log("Insufficient Money For this purchase");
                dress.SetActive(false);
                store.SetActive(true);
            }
        }

        else if (priceTag.activeSelf == true && MainManager.Instance.Purchased_Coats[selected - 10] == 0 && side_button_number == 2)
        {
            if (MainManager.Instance.Coins >= price)
            {
                MainManager.Instance.Coins = MainManager.Instance.Coins - price;
                MainManager.Instance.Purchased_Coats[selected - 10] = selected;
                priceTag.SetActive(false);

                Debug.Log("Price Tag Set to inactive...");
                Remaining_Coins.text = MainManager.Instance.Coins.ToString();
                dress.SetActive(true);
                MainManager.Instance.SaveUserData();
            }
            else
            {
                Debug.Log("Insufficient Money For this purchase");
                dress.SetActive(false);
                store.SetActive(true);
            }
        }

        else if (priceTag.activeSelf == true && MainManager.Instance.Purchased_Ties[selected - 10] == 0 && side_button_number == 3)
        {
            if (MainManager.Instance.Coins >= price)
            {
                MainManager.Instance.Coins = MainManager.Instance.Coins - price;
                MainManager.Instance.Purchased_Ties[selected - 10] = selected;
                priceTag.SetActive(false);

                Debug.Log("Price Tag Set to inactive...");
                Remaining_Coins.text = MainManager.Instance.Coins.ToString();
                dress.SetActive(true);
                MainManager.Instance.SaveUserData();
            }
            else
            {
                Debug.Log("Insufficient Money For this purchase");
                dress.SetActive(false);
                store.SetActive(true);
            }
        }

        else if (priceTag.activeSelf == true && MainManager.Instance.Purchased_Hairstyles[selected - 10] == 0 && side_button_number == 4)
        {
            if (MainManager.Instance.Coins >= price)
            {
                MainManager.Instance.Coins = MainManager.Instance.Coins - price;
                MainManager.Instance.Purchased_Hairstyles[selected - 10] = selected;
                priceTag.SetActive(false);

                Debug.Log("Price Tag Set to inactive...");
                Remaining_Coins.text = MainManager.Instance.Coins.ToString();
                dress.SetActive(true);
                MainManager.Instance.SaveUserData();
            }
            else
            {
                Debug.Log("Insufficient Money For this purchase");
                dress.SetActive(false);
                store.SetActive(true);
            }
        }

        else if (priceTag.activeSelf == true && MainManager.Instance.Purchased_Shoes_W[selected - 10] == 0 && side_button_number == 5)
        {
            if (MainManager.Instance.Coins >= price)
            {
                MainManager.Instance.Coins = MainManager.Instance.Coins - price;
                MainManager.Instance.Purchased_Shoes_W[selected - 10] = selected;
                priceTag.SetActive(false);

                Debug.Log("Price Tag Set to inactive...");
                Remaining_Coins.text = MainManager.Instance.Coins.ToString();
                dress.SetActive(true);
                MainManager.Instance.SaveUserData();
            }
            else
            {
                Debug.Log("Insufficient Money For this purchase");
                dress.SetActive(false);
                store.SetActive(true);
            }
        }
    }
}
