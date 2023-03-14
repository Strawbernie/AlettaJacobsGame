using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using Unity.VisualScripting;
using UnityEngine.EventSystems;
using System.Diagnostics.Contracts;
using UnityEngine.UIElements;

public class CameraSwitcher : MonoBehaviour
{
    public GameObject vCam1;
    public GameObject vCam2;
    public GameObject vCam3;
    public GameObject vCam4;
    public GameObject zoomBBed;
  

    private void Start()
    {
        vCam1.active = true;
        vCam2.active = false;
        vCam3.active = false;
        vCam4.active = false;
        zoomBBed.active = false;
    }


 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { 

                if (vCam1.active == true)
                {
                    vCam1.active = false;
                    vCam2.active = true;
                }
                else if (vCam2.active == true)
                {
                    vCam2.active = false;
                    vCam3.active = true;
                }
                else if (vCam3.active == true)
                {
                    vCam4.active = true;
                    vCam3.active = false;
                }
                else if (vCam4.active == true)
                {
                    vCam1.active = true;
                    vCam4.active = false;
                }
            }
            
            
        }
    
}
