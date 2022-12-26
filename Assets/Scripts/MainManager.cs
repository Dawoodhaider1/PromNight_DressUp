using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    public int avatar_selected;
    public int Coins = 1000;
    //Male Model
    public int[] Purchased_Shirts = new int[5];
    public int[] Purchased_Pants = new int[5];
    public int[] Purchased_Coats = new int[5];
    public int[] Purchased_Ties = new int[5];
    public int[] Purchased_Hairstyles = new int[5];
    public int[] Purchased_Shoes_W = new int[5];

    //Female Model
    public int[] Purchased_Dresses = new int[5];
    public int[] Purchased_HandBags = new int[5];
    public int[] Purchased_Jewelry = new int[5];
    public int[] Purchased_Crown = new int[5];
    public int[] Purchased_Hairstyles_Female = new int[5];
    public int[] Purchased_Shoes_Female = new int[5];

    public int item;
    public int side_button_number;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        //SaveUserData();
        LoadUserData();
    }

    [System.Serializable]
    class SaveData
    {
        public int avatar_selected;
        public int Coins;
        public int item;
        //Male Model
        public int[] purchased_Shirts = new int[5];
        public int[] purchased_Pants = new int[5];
        public int[] purchased_Coats = new int[5];
        public int[] purchased_Ties = new int[5];
        public int[] purchased_Hairstyles = new int[5];
        public int[] purchased_Shoes_W = new int[5];

        //Female Model
        public int[] Purchased_Dresses = new int[5];
        public int[] Purchased_HandBags = new int[5];
        public int[] Purchased_Jewelry = new int[5];
        public int[] Purchased_Crown = new int[5];
        public int[] Purchased_Hairstyles_Female = new int[5];
        public int[] Purchased_Shoes_Female = new int[5];
    }

    public void SaveUserData()
    {
        SaveData data = new SaveData();
        data.avatar_selected = avatar_selected;
        data.Coins = Coins;
        data.item = item;
        //Male Model
        for (int i = 0; i < Purchased_Shirts.Length; i++)
        {
            data.purchased_Shirts[i] = Purchased_Shirts[i];
        }
        for (int i = 0; i < Purchased_Pants.Length; i++)
        {
            data.purchased_Pants[i] = Purchased_Pants[i];
        }
        for (int i = 0; i < Purchased_Coats.Length; i++)
        {
            data.purchased_Coats[i] = Purchased_Coats[i];
        }
        for (int i = 0; i < Purchased_Hairstyles.Length; i++)
        {
            data.purchased_Hairstyles[i] = Purchased_Hairstyles[i];
        }
        for (int i = 0; i < Purchased_Ties.Length; i++)
        {
            data.purchased_Ties[i] = Purchased_Ties[i];
        }
        for (int i = 0; i < Purchased_Shoes_W.Length; i++)
        {
            data.purchased_Shoes_W[i] = Purchased_Shoes_W[i];
        }

        //Female Model
        for (int i = 0; i < Purchased_Dresses.Length; i++)
        {
            data.Purchased_Dresses[i] = Purchased_Dresses[i];
        }
        for (int i = 0; i < Purchased_HandBags.Length; i++)
        {
            data.Purchased_HandBags[i] = Purchased_HandBags[i];
        }
        for (int i = 0; i < Purchased_Jewelry.Length; i++)
        {
            data.Purchased_Jewelry[i] = Purchased_Jewelry[i];
        }
        for (int i = 0; i < Purchased_Crown.Length; i++)
        {
            data.Purchased_Crown[i] = Purchased_Crown[i];
        }
        for (int i = 0; i < Purchased_Hairstyles_Female.Length; i++)
        {
            data.Purchased_Hairstyles_Female[i] = Purchased_Hairstyles_Female[i];
        }
        for (int i = 0; i < Purchased_Shoes_Female.Length; i++)
        {
            data.Purchased_Shoes_Female[i] = Purchased_Shoes_Female[i];
        }

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadUserData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            avatar_selected = data.avatar_selected;
            Coins = data.Coins;
            item = data.item;

            //Male Model
            for (int i = 0; i < Purchased_Shirts.Length; i++)
            {
                Purchased_Shirts[i] = data.purchased_Shirts[i];
            }
            for (int i = 0; i < Purchased_Pants.Length; i++)
            {
                Purchased_Pants[i] = data.purchased_Pants[i];
            }
            for (int i = 0; i < Purchased_Coats.Length; i++)
            {
                Purchased_Coats[i] = data.purchased_Coats[i];
            }
            for (int i = 0; i < Purchased_Hairstyles.Length; i++)
            {
                Purchased_Hairstyles[i] = data.purchased_Hairstyles[i];
            }
            for (int i = 0; i < Purchased_Ties.Length; i++)
            {
                Purchased_Ties[i] = data.purchased_Ties[i];
            }
            for (int i = 0; i < Purchased_Shoes_W.Length; i++)
            {
                Purchased_Shoes_W[i] = data.purchased_Shoes_W[i];
            }

            //Female Model
            for (int i = 0; i < Purchased_Dresses.Length; i++)
            {
                Purchased_Dresses[i] = data.Purchased_Dresses[i];
            }
            for (int i = 0; i < Purchased_HandBags.Length; i++)
            {
                Purchased_HandBags[i] = data.Purchased_HandBags[i];
            }
            for (int i = 0; i < Purchased_Jewelry.Length; i++)
            {
                Purchased_Jewelry[i] = data.Purchased_Jewelry[i];
            }
            for (int i = 0; i < Purchased_Crown.Length; i++)
            {
                Purchased_Crown[i] = data.Purchased_Crown[i];
            }
            for (int i = 0; i < Purchased_Hairstyles_Female.Length; i++)
            {
                Purchased_Hairstyles_Female[i] = data.Purchased_Hairstyles_Female[i];
            }
            for (int i = 0; i < Purchased_Shoes_Female.Length; i++)
            {
                Purchased_Shoes_Female[i] = data.Purchased_Shoes_Female[i];
            }

        }
    }

}
