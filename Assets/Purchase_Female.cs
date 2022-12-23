using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Purchase_Female : MonoBehaviour
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

        //Female Model
        if (priceTag.activeSelf == true && MainManager.Instance.Purchased_Dresses[selected - 10] == 0 && side_button_number == 0)
        {
            if (MainManager.Instance.Coins >= price)
            {
                MainManager.Instance.Coins = MainManager.Instance.Coins - price;
                MainManager.Instance.Purchased_Dresses[selected - 10] = selected;
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

        else if (priceTag.activeSelf == true && MainManager.Instance.Purchased_HandBags[selected - 10] == 0 && side_button_number == 1)
        {
            if (MainManager.Instance.Coins >= price)
            {
                MainManager.Instance.Coins = MainManager.Instance.Coins - price;
                MainManager.Instance.Purchased_HandBags[selected - 10] = selected;
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

        else if (priceTag.activeSelf == true && MainManager.Instance.Purchased_Jewelry[selected - 10] == 0 && side_button_number == 2)
        {
            if (MainManager.Instance.Coins >= price)
            {
                MainManager.Instance.Coins = MainManager.Instance.Coins - price;
                MainManager.Instance.Purchased_Jewelry[selected - 10] = selected;
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

        else if (priceTag.activeSelf == true && MainManager.Instance.Purchased_Crown[selected - 10] == 0 && side_button_number == 3)
        {
            if (MainManager.Instance.Coins >= price)
            {
                MainManager.Instance.Coins = MainManager.Instance.Coins - price;
                MainManager.Instance.Purchased_Crown[selected - 10] = selected;
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

        else if (priceTag.activeSelf == true && MainManager.Instance.Purchased_Hairstyles_Female[selected - 10] == 0 && side_button_number == 4)
        {
            if (MainManager.Instance.Coins >= price)
            {
                MainManager.Instance.Coins = MainManager.Instance.Coins - price;
                MainManager.Instance.Purchased_Hairstyles_Female[selected - 10] = selected;
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

        else if (priceTag.activeSelf == true && MainManager.Instance.Purchased_Shoes_Female[selected - 10] == 0 && side_button_number == 5)
        {
            if (MainManager.Instance.Coins >= price)
            {
                MainManager.Instance.Coins = MainManager.Instance.Coins - price;
                MainManager.Instance.Purchased_Shoes_Female[selected - 10] = selected;
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
