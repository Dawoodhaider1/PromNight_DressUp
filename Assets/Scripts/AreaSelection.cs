using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AreaSelection : MonoBehaviour
{
    public List<GamePlay_buttons> sideBar_Buttons;
    public GamePlay_buttons selectedButton;
    public List<GameObject> Areas;

    public void OnClickSelected(GamePlay_buttons button)
    {
        selectedButton = button;
        int index = button.transform.GetSiblingIndex();
        for (int i = 0; i < Areas.Count; i++)
        {
            if (i == index)
            {
                Areas[i].SetActive(true);
            }
            else
            {
                Areas[i].SetActive(false);
            }
        }
    }

    public void ResetButtons()
    {
        foreach (GamePlay_buttons button in sideBar_Buttons)
        {
            if (selectedButton != null && button == selectedButton) { continue; }
        }
    }
}
