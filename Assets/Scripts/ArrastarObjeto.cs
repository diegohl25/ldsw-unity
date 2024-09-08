using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ArrastarObjeto : MonoBehaviour, IDragHandler
{
    Canvas canvas;
    RectTransform dragRect;

    public void Awake(){
        dragRect = GetComponent<RectTransform>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        dragRect.anchoredPosition += eventData.delta;
    }
}
