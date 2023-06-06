using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExamCameraSwitch : MonoBehaviour
{
    public GameObject Camera4;
    public Vector3 CameraLoc;
    private float t;
    public GameObject Button1;
    public GameObject Button2;
   public void OnButtonPress()
    {
        Camera4.transform.position = Vector3.Lerp(CameraLoc, CameraLoc, t);
        Button1.SetActive(true);
        Button2.SetActive(false);
    }
}
