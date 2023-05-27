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
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == key)
            {
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

