using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl4Buttons : MonoBehaviour
{
    public GameObject DownButton;
    public GameObject UpButton;
    public GameObject HandIn;
    // Start is called before the first frame update
    private void Update()
    {
        if (Camera.main.transform.localEulerAngles.y > 189f && Camera.main.transform.localEulerAngles.y < 190f && !UpButton.activeSelf)
        {
            DownButton.SetActive(true);
            HandIn.SetActive(true);
        }
        else if (Camera.main.transform.localEulerAngles.y > 189f && Camera.main.transform.localEulerAngles.y < 190f)
        {
            UpButton.SetActive(true);
        }
        else
        {
            HandIn.SetActive(false);
            UpButton.SetActive(false);
            DownButton.SetActive(false);
        }
    }
}
