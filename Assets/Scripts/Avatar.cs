using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Avatar : MonoBehaviour
{
    public Sprite[] images;
    public Image imageContainer;

    void Start()
    {
        int ind = MainManager.Instance.avatar_selected;
        SetImage(ind);
    }

    public void SetImage(int index)
    {
        MainManager.Instance.avatar_selected = index;

        if (images.Length >= index)
        {
            imageContainer.sprite = images[index];
        }
        else
        {
            Debug.LogError("Invalid image index: " + index);
        }

        MainManager.Instance.SaveUserData();
    }
}
