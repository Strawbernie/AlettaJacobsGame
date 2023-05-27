using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisabledMode : MonoBehaviour
{
    public GameObject goBack;
    public GameObject timeTravel;
    public GameObject camera4;

    public bool swipeDisabled = true;
    public bool zoomDisabled = true;
    public bool touchDisabled = true;
    public bool goBackDisabled = true;
    public bool timeTravelDisabled = true;

    private void Update()
    {
        // switch buttons appearing on the screen depending on its be
        if (goBackDisabled)
        {
            goBack.SetActive(false);
            if (!timeTravelDisabled)
            {
                timeTravel.SetActive(true);
            }
            else
            {
                timeTravel.SetActive(false);
            }
        }
        else
        {
            goBack.SetActive(true);
            timeTravel.SetActive(false);
        }

    }
}
