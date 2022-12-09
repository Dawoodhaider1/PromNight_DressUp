using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Side_buttons : MonoBehaviour
{
    //Button button = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();

    public void getindex(int x)
    {
        MainManager.Instance.side_button_number = x;
    }
}
