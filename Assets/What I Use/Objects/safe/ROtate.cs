using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROtate : MonoBehaviour
{
    public static event Action<string, int> Rotated = delegate { };

    private bool coroutineAllowed;

    private int numberShown;

    // Start is called before the first frame update
    void Start()
    {
        coroutineAllowed = true;
        numberShown = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                // code for detecting taps on object
                if (coroutineAllowed)
                {
                    StartCoroutine("RotateWheel");
                }
            }
        }
    }

    private IEnumerator RotateWheel()
    {
        coroutineAllowed = false;

        for (int i = 0; i <= 11; i++)
        {
            transform.Rotate(0f, 0f, 3f);
            yield return new WaitForSeconds(0.01f);
        }

        coroutineAllowed = true;

        numberShown += 1;

        if (numberShown > 9)
        {
            numberShown = 0;
        }

        Rotated(name, numberShown);
    }
}
