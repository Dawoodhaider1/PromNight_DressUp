using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bought : MonoBehaviour
{
    public GameObject[] priceTag_ME_dresses = new GameObject[5];
    public GameObject[] priceTag_ME_Shoes = new GameObject[5];
    public GameObject[] priceTag_ME_turbans = new GameObject[5];

    public GameObject[] priceTag_W_shirts = new GameObject[5];
    public GameObject[] priceTag_W_pants = new GameObject[5];
    public GameObject[] priceTag_W_Coats = new GameObject[5];
    public GameObject[] priceTag_W_ties = new GameObject[5];
    public GameObject[] priceTag_W_hairstyles = new GameObject[5];
    public GameObject[] priceTag_W_shoes = new GameObject[5];

    public GameObject[] priceTag_SA_sherwani = new GameObject[5];
    public GameObject[] priceTag_SA_trousers = new GameObject[5];
    public GameObject[] priceTag_SA_shawls = new GameObject[5];
    public GameObject[] priceTag_SA_turbans = new GameObject[5];
    public GameObject[] priceTag_SA_khussas = new GameObject[5];

    void Start()
    {
        
        //Middle Eastern
        for(int i = 0; i <= 4/*MainManager.Instance.Purchased_Dresses.Length*/; i++)
        {
            if (MainManager.Instance.Purchased_Dresses[i] != 0)
            {
                priceTag_ME_dresses[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        for (int i = 0; i <= 4/*MainManager.Instance.Purchased_Shoes_ME.Length*/; i++)
        {
            if (MainManager.Instance.Purchased_Shoes_ME[i] != 0)
            {
                priceTag_ME_Shoes[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        for (int i = 0; i <= 4/*MainManager.Instance.Purchased_Turbans_ME.Length*/; i++)
        {
            if (MainManager.Instance.Purchased_Turbans_ME[i] != 0)
            {
                priceTag_ME_turbans[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        //Western
        for (int i = 0; i <= 4/*MainManager.Instance.Purchased_Shirts.Length*/; i++)
        {
            if (MainManager.Instance.Purchased_Shirts[i] != 0)
            {
                priceTag_W_shirts[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        for (int i = 0; i <= 4/*MainManager.Instance.Purchased_Pants.Length*/; i++)
        {
            if (MainManager.Instance.Purchased_Pants[i] != 0)
            {
                priceTag_W_pants[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        for (int i = 0; i <= 4/*MainManager.Instance.Purchased_Coats.Length*/; i++)
        {
            if (MainManager.Instance.Purchased_Coats[i] != 0)
            {
                priceTag_W_Coats[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        for (int i = 0; i <= 4/*MainManager.Instance.Purchased_Ties.Length*/; i++)
        {
            if (MainManager.Instance.Purchased_Ties[i] != 0)
            {
                priceTag_W_ties[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        for (int i = 0; i <= 4/*MainManager.Instance.Purchased_Hairstyles.Length*/; i++)
        {
            if (MainManager.Instance.Purchased_Hairstyles[i] != 0)
            {
                priceTag_W_hairstyles[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        for (int i = 0; i <= 4/*MainManager.Instance.Purchased_Shoes_W.Length*/; i++)
        {
            if (MainManager.Instance.Purchased_Shoes_W[i] != 0)
            {
                priceTag_W_shoes[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        //South Asian
        for (int i = 0; i <= 4/*MainManager.Instance.Purchased_Sherwani.Length*/; i++)
        {
            if (MainManager.Instance.Purchased_Sherwani[i] != 0)
            {
                priceTag_SA_sherwani[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        for (int i = 0; i <= 4/*MainManager.Instance.Purchased_Trousers.Length*/; i++)
        {
            if (MainManager.Instance.Purchased_Trousers[i] != 0)
            {
                priceTag_SA_trousers[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        for (int i = 0; i <= 4/*MainManager.Instance.Purchased_Shawls.Length*/; i++)
        {
            if (MainManager.Instance.Purchased_Shawls[i] != 0)
            {
                priceTag_SA_shawls[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        for (int i = 0; i <= 4/*MainManager.Instance.Purchased_Turbans_SA.Length*/; i++)
        {
            if (MainManager.Instance.Purchased_Turbans_SA[i] != 0)
            {
                priceTag_SA_turbans[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        for (int i = 0; i <= 4/*MainManager.Instance.Purchased_Khussas.Length*/; i++)
        {
            if (MainManager.Instance.Purchased_Khussas[i] != 0)
            {
                priceTag_SA_khussas[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }
    }
}
