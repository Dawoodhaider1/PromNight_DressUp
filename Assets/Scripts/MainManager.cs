using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    public int avatar_selected;
    public int Coins = 1000;
    //Middle Eastern
    public int[] Purchased_Dresses = new int[5];
    public int[] Purchased_Shoes_ME = new int[5];
    public int[] Purchased_Turbans_ME = new int[5];
    //Western
    public int[] Purchased_Shirts = new int[5];
    public int[] Purchased_Pants = new int[5];
    public int[] Purchased_Coats = new int[5];
    public int[] Purchased_Ties = new int[5];
    public int[] Purchased_Hairstyles = new int[5];
    public int[] Purchased_Shoes_W = new int[5];
    //South Asian
    public int[] Purchased_Sherwani = new int[5];
    public int[] Purchased_Trousers = new int[5];
    public int[] Purchased_Shawls = new int[5];
    public int[] Purchased_Turbans_SA = new int[5];
    public int[] Purchased_Khussas = new int[5];

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
        //Middle Eastern
        public int[] purchased_Dresses = new int[5];
        public int[] purchased_Shoes_ME = new int[5];
        public int[] purchased_Turbans_ME = new int[5];
        //Western
        public int[] purchased_Shirts = new int[5];
        public int[] purchased_Pants = new int[5];
        public int[] purchased_Coats = new int[5];
        public int[] purchased_Ties = new int[5];
        public int[] purchased_Hairstyles = new int[5];
        public int[] purchased_Shoes_W = new int[5];
        //South Asian
        public int[] purchased_Sherwani = new int[5];
        public int[] purchased_Trousers = new int[5];
        public int[] purchased_Shawls = new int[5];
        public int[] purchased_Turbans_SA = new int[5];
        public int[] purchased_Khussas = new int[5];
    }

    public void SaveUserData()
    {
        SaveData data = new SaveData();
        data.avatar_selected = avatar_selected;
        data.Coins = Coins;
        data.item = item;
        //Middle Eastern
        for(int i = 0; i < 5; i++)
        {
            data.purchased_Dresses[i] = Purchased_Dresses[i];
        }
        for (int i = 0; i < 5; i++)
        {
            data.purchased_Shoes_ME[i] = Purchased_Shoes_ME[i];
        }
        for (int i = 0; i < 5; i++)
        {
            data.purchased_Turbans_ME[i] = Purchased_Turbans_ME[i];
        }
        //Western
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
        //South Asia
        for (int i = 0; i < Purchased_Sherwani.Length; i++)
        {
            data.purchased_Sherwani[i] = Purchased_Sherwani[i];
        }
        for (int i = 0; i < Purchased_Trousers.Length; i++)
        {
            data.purchased_Trousers[i] = Purchased_Trousers[i];
        }
        for (int i = 0; i < Purchased_Shawls.Length; i++)
        {
            data.purchased_Shawls[i] = Purchased_Shawls[i];
        }
        for (int i = 0; i < Purchased_Turbans_SA.Length; i++)
        {
            data.purchased_Turbans_SA[i] = Purchased_Turbans_SA[i];
        }
        for (int i = 0; i < Purchased_Khussas.Length; i++)
        {
            data.purchased_Khussas[i] = Purchased_Khussas[i];
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
            //Middle Eastern
            for (int i = 0; i < 5; i++)
            {
                Purchased_Dresses[i] = data.purchased_Dresses[i];
            }
            for (int i = 0; i < 5; i++)
            {
                Purchased_Shoes_ME[i] = data.purchased_Shoes_ME[i];
            }
            for (int i = 0; i < Purchased_Turbans_ME.Length; i++)
            {
                Purchased_Turbans_ME[i] = data.purchased_Turbans_ME[i];
            }

            //Western
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
            //South Asian
            for (int i = 0; i < Purchased_Sherwani.Length; i++)
            {
                Purchased_Sherwani[i] = data.purchased_Sherwani[i];
            }
            for (int i = 0; i < Purchased_Trousers.Length; i++)
            {
                Purchased_Trousers[i] = data.purchased_Trousers[i];
            }
            for (int i = 0; i < Purchased_Shawls.Length; i++)
            {
                Purchased_Shawls[i] = data.purchased_Shawls[i];
            }
            for (int i = 0; i < Purchased_Turbans_SA.Length; i++)
            {
                Purchased_Turbans_SA[i] = data.purchased_Turbans_SA[i];
            }
            for (int i = 0; i < Purchased_Khussas.Length; i++)
            {
                Purchased_Khussas[i] = data.purchased_Khussas[i];
            }
        }
    }

}
