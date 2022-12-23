using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomBackground : MonoBehaviour
{

    // Declare a public array of sprites that will be used as the backgrounds
    public Sprite[] backgrounds;
    public Image imageContainer;

    void Start()
    {
        // If the array of backgrounds is not empty
        if (backgrounds.Length > 0)
        {
            // Choose a random background from the array and apply
            imageContainer.sprite = backgrounds[Random.Range(0, backgrounds.Length)];
        }
    }
}
