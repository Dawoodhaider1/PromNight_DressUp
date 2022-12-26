using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bought : MonoBehaviour
{
    public GameObject[] priceTag_shirts = new GameObject[5];
    public GameObject[] priceTag_pants = new GameObject[5];
    public GameObject[] priceTag_Coats = new GameObject[5];
    public GameObject[] priceTag_ties = new GameObject[5];
    public GameObject[] priceTag_hairstyles = new GameObject[5];
    public GameObject[] priceTag_shoes = new GameObject[5];

    public GameObject[] priceTag_Dress_Female = new GameObject[5];
    public GameObject[] priceTag_HandBags_Female = new GameObject[5];
    public GameObject[] priceTag_Jewelry_Female = new GameObject[5];
    public GameObject[] priceTag_Crown_Female = new GameObject[5];
    public GameObject[] priceTag_hairstyles_Female = new GameObject[5];
    public GameObject[] priceTag_shoes_Female = new GameObject[5];

    void Start()
    {
        //Male Model
        for (int i = 0; i <= 4/*MainManager.Instance.Purchased_Shirts.Length*/; i++)
        {
            if (MainManager.Instance.Purchased_Shirts[i] != 0)
            {
                priceTag_shirts[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        for (int i = 0; i <= 4/*MainManager.Instance.Purchased_Pants.Length*/; i++)
        {
            if (MainManager.Instance.Purchased_Pants[i] != 0)
            {
                priceTag_pants[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        for (int i = 0; i <= 4/*MainManager.Instance.Purchased_Coats.Length*/; i++)
        {
            if (MainManager.Instance.Purchased_Coats[i] != 0)
            {
                priceTag_Coats[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        for (int i = 0; i <= 4/*MainManager.Instance.Purchased_Ties.Length*/; i++)
        {
            if (MainManager.Instance.Purchased_Ties[i] != 0)
            {
                priceTag_ties[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        for (int i = 0; i <= 4/*MainManager.Instance.Purchased_Hairstyles.Length*/; i++)
        {
            if (MainManager.Instance.Purchased_Hairstyles[i] != 0)
            {
                priceTag_hairstyles[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        for (int i = 0; i <= 4/*MainManager.Instance.Purchased_Shoes_W.Length*/; i++)
        {
            if (MainManager.Instance.Purchased_Shoes_W[i] != 0)
            {
                priceTag_shoes[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        //Female Model
        for (int i = 0; i <= 4/*MainManager.Instance.Purchased_Shirts.Length*/; i++)
        {
            if (MainManager.Instance.Purchased_Dresses[i] != 0)
            {
                priceTag_Dress_Female[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        for (int i = 0; i <= 4/*MainManager.Instance.Purchased_Pants.Length*/; i++)
        {
            if (MainManager.Instance.Purchased_HandBags[i] != 0)
            {
                priceTag_HandBags_Female[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        for (int i = 0; i <= 4/*MainManager.Instance.Purchased_Coats.Length*/; i++)
        {
            if (MainManager.Instance.Purchased_Jewelry[i] != 0)
            {
                priceTag_Jewelry_Female[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        for (int i = 0; i <= 4/*MainManager.Instance.Purchased_Ties.Length*/; i++)
        {
            if (MainManager.Instance.Purchased_Crown[i] != 0)
            {
                priceTag_Crown_Female[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        for (int i = 0; i <= 4/*MainManager.Instance.Purchased_Hairstyles.Length*/; i++)
        {
            if (MainManager.Instance.Purchased_Hairstyles_Female[i] != 0)
            {
                priceTag_hairstyles_Female[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        for (int i = 0; i <= 4/*MainManager.Instance.Purchased_Shoes_W.Length*/; i++)
        {
            if (MainManager.Instance.Purchased_Shoes_Female[i] != 0)
            {
                priceTag_shoes_Female[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }
    }
}
