using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muted : MonoBehaviour
{
    public AudioSource GameMusic;

    public void Mute(bool muted)
    {
        if (muted)
        {
            AudioListener.volume = 0;
            GameMusic.Stop();
        }
        else
        {
            AudioListener.volume = 1;
            GameMusic.Play();
        }
    }
}
