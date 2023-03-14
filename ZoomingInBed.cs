using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ZoomingInBed : MonoBehaviour, IPointerClickHandler
{
    public GameObject zoom;

    void Start() {
        zoom.active = false;
    }
    public void OnPointerClick(PointerEventData zoomIn)
    {
        if (zoom.active == false && zoomIn.pointerId == -1)
        {
            zoom.active = true;
        }
        else if (zoom.active == true && zoomIn.pointerId == -2)
        {
            zoom.active = false;
        }
    }
}