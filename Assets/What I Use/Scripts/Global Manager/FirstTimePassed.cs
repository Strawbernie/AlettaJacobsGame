using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTimePassed : MonoBehaviour
{
    public bool firstTimeLevel1 = true;
    public bool firstTimeLevel2 = true;
    public bool firstTimeEntered = true;
    public bool firstTimeLevel3 = true;
    public bool firstTimeLevel4 = true;
    public bool firstTimeLevel5 = true;
    public bool firstTimeLevel6 = true;

    public DisabledMode disabledMode;

    private void Update()
    {
        if (!firstTimeEntered)
        {
            disabledMode.timeTravelDisabled = false;
        }
    }
}
