using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectedOpponent : MonoBehaviour
{
    public Sprite[] images;
    public Image imageContainer;

    private static int index;

    private void Start()
    {
        index = opponentAvatar.randIndex;
        SetImage();
    }

    public void SetImage()
    {
        if (images.Length >= index)
        {
            imageContainer.sprite = images[index];
        }
        else
        {
            Debug.LogError("Invalid image index: " + index);
        }
    }
}
