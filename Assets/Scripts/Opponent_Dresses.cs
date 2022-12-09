using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Opponent_Dresses : MonoBehaviour
{
    public Sprite[] images;
    public Image imageContainer;
    public static int Dress;

    private void Start()
    {
        Dress = Random.Range(0, 25);
        SetImage();
    }

    public void SetImage()
    {
        if (images.Length >= Dress)
        {
            imageContainer.sprite = images[Dress];
            imageContainer.SetNativeSize();
        }
        else
        {
            Debug.LogError("Invalid image index: " + Dress);
        }
    }
}
