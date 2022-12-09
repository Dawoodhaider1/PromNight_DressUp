using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Animator anim;
    public GameObject win_Scene;
    public GameObject loose_Scene;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if(win_Scene.activeSelf == true)
        {
            anim.SetBool("Result_active", true);
        }
        if(loose_Scene.activeSelf == true)
        {
            anim.SetBool("Result_active", true);
        }
    }

}
