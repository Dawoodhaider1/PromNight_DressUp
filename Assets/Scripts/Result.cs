using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result : MonoBehaviour
{
    public GameObject Result_screen;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3f);
        Result_screen.SetActive(true);
    }
}
