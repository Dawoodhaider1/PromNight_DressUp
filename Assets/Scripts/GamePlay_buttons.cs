using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GamePlay_buttons : MonoBehaviour, IPointerClickHandler
{
    public AreaSelection GamePlay;

    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        GamePlay.OnClickSelected(this);
    }
}
