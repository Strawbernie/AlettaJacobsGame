using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Disables ObjAnim for objects that are not in the level
/// </summary>
public class ObjAnimController : MonoBehaviour
{
    public GameObject camera3;

    public GameObject cupboard;

    public KeyChecker keyCheck;

    // Update is called once per frame
    void Update()
    {
        if (camera3.activeSelf)
        {
            if (keyCheck.hasKey)
            {
                cupboard.GetComponent<ObjAnimCupboard>().enabled = true;
                camera3.GetComponent<ZoomInOut>().enabled = true;
            }
            else
            {
                cupboard.GetComponent<ObjAnimCupboard>().enabled = false;
                camera3.GetComponent<ZoomInOut>().enabled = false;
            }
        }
    }
}
