using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public Slider volumeSlider;
    void Start()
    {
        volumeSlider.value = MainManager.Instance.VolumeValue;
    }

    void Update()
    {
        AudioListener.volume = volumeSlider.value;
        MainManager.Instance.VolumeValue = volumeSlider.value;
        MainManager.Instance.SaveUserData();
    }
}
