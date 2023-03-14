using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsDissapearing : MonoBehaviour

    {
    public GameObject Wall1;
    public GameObject Wall2;
    public GameObject Wall3;
    public GameObject Wall4;

    // Update is called once per frame
    void Update()
    {
        if (Camera.main.transform.localEulerAngles.y > -90.0f && Camera.main.transform.localEulerAngles.y < 90.0f)
        {
            Wall1.SetActive(true);
            Wall2.SetActive(true);
            Wall3.SetActive(false);
            Wall4.SetActive(false);

        }

        else if (Camera.main.transform.localEulerAngles.y > 0.0f && Camera.main.transform.localEulerAngles.y < 180.0f)
        {
            Wall1.SetActive(false);
            Wall2.SetActive(true);
            Wall3.SetActive(true);
            Wall4.SetActive(false);
        }

        else if (Camera.main.transform.localEulerAngles.y > 90.0f && Camera.main.transform.localEulerAngles.y < 270.0f)
        {
            Wall1.SetActive(false);
            Wall2.SetActive(false);
            Wall3.SetActive(true);
            Wall4.SetActive(true);
        }

        else
        {
            Wall1.SetActive(true);
            Wall2.SetActive(false);
            Wall3.SetActive(false);
            Wall4.SetActive(true);
        }
    }
}