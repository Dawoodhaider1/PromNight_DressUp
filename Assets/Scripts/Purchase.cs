using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Purchase : MonoBehaviour
{
    public int price;
    public GameObject priceTag;
    public GameObject dress;
    public GameObject store;
    public Text Remaining_Coins;

    private int selected;
    private int side_button_number;

    public void OnClickButton()
    {
        Button button = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
        selected = MainManager.Instance.item;
        side_button_number = MainManager.Instance.side_button_number;
        Debug.Log("The selected Item is:" + selected);

        //Middle Eastern
            if (priceTag.activeSelf == true && MainManager.Instance.Purchased_Dresses[selected - 5] == 0 && side_button_number == 0)
            {
                if (MainManager.Instance.Coins >= price)
                {
                    MainManager.Instance.Coins = MainManager.Instance.Coins - price;
                    MainManager.Instance.Purchased_Dresses[selected - 5] = selected;
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

            else if (priceTag.activeSelf == true && MainManager.Instance.Purchased_Shoes_ME[selected - 5] == 0 && side_button_number == 1)
            {
                if (MainManager.Instance.Coins >= price)
                {
                    MainManager.Instance.Coins = MainManager.Instance.Coins - price;
                    MainManager.Instance.Purchased_Shoes_ME[selected - 5] = selected;
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

            else if (priceTag.activeSelf == true && MainManager.Instance.Purchased_Turbans_ME[selected - 5] == 0 && side_button_number == 2)
            {
                if (MainManager.Instance.Coins >= price)
                {
                    MainManager.Instance.Coins = MainManager.Instance.Coins - price;
                    MainManager.Instance.Purchased_Turbans_ME[selected - 5] = selected;
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
