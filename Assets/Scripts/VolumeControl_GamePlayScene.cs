using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeControl_GamePlayScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        AudioListener.volume = MainManager.Instance.VolumeValue;
    }
}
