using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyChecker : MonoBehaviour
{
    public GameObject key;

    public GameObject camera3;
    public ZoomInOut camera3ZoomInOutScript;

    public bool hasKey = false;

    public FirstTimePassed firstTimePassed;
    public GameObject ParticleSystem;

    void Update()
    {
        //if the player touches the screen
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            //check if the tap hits the key
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == key)
            {
                //if it hits, destroy the key and its particlesystem, and set hasKey to true
                Destroy(key);
                Destroy(ParticleSystem);
                hasKey = true;
            }
        }
        if (camera3.activeSelf && firstTimePassed.firstTimeEntered)
        {
            firstTimePassed.firstTimeEntered = false;
        }
    }
}

