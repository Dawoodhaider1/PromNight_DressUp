using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public GameObject Chest_Closed;
    public GameObject Chest_Opened;
    Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
        StartCoroutine(animation_time());
    }

    IEnumerator animation_time()
    {
        yield return new WaitForSeconds(1.1f);
        Chest_Closed.SetActive(false);
        Chest_Opened.SetActive(true);
    }
}
