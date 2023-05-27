using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Disables ObjAnim for objects that are not in the level
/// </summary>
public class ObjAnimController : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;

    public GameObject babyBed;
    public GameObject suitcase;
    public GameObject chest;

    public KeyChecker keyCheck;

    // Update is called once per frame
    void Update()
    {
        if (camera1.activeSelf)
        {
            babyBed.GetComponent<ObjAnim>().enabled = true;
            suitcase.GetComponent<ObjAnim>().enabled = false;
            chest.GetComponent<ObjAnim>().enabled = false;
        }
        if (camera2.activeSelf)
        {
            babyBed.GetComponent<ObjAnim>().enabled = false;
            suitcase.GetComponent<ObjAnim>().enabled = true;
            chest.GetComponent<ObjAnim>().enabled = false;
        }
        if (camera3.activeSelf)
        {
            babyBed.GetComponent<ObjAnim>().enabled = false;
            suitcase.GetComponent<ObjAnim>().enabled = false;

            if (keyCheck.hasKey)
            {
                chest.GetComponent<ObjAnim>().enabled = true;
                camera3.GetComponent<ZoomInOut>().enabled = true;
            }
            else
            {
                chest.GetComponent<ObjAnim>().enabled = false;
                camera3.GetComponent<ZoomInOut>().enabled = false;
            }
        }
    }
}
