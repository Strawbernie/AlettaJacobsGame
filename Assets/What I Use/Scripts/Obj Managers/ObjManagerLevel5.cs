using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjManagerLevel5 : MonoBehaviour
{
    // Level's objects
    public GameObject door;
    public GameObject painting1;
    public GameObject cupboard1;
    public GameObject bed;
    public GameObject painting2;
    public GameObject plant2;
    public GameObject cupboard2;
    public GameObject lamp;
    public GameObject curtain1;
    public GameObject curtain2;
    public GameObject mirror;
    public GameObject mirrorReflection;
    public GameObject painting4;
    public GameObject fireplace;
    public GameObject PicFrameFancy;
    public GameObject Puzzle;
    public GameObject PS;

    // Level's walls
    public GameObject Wall1;
    public GameObject Wall2;
    public GameObject Wall3;
    public GameObject Wall4;

    // Update is called once per frame
    void Update()
    {
        // Walls 12
        if (Camera.main.transform.localEulerAngles.y > -90.0f && Camera.main.transform.localEulerAngles.y < 90.0f)
        {
            Wall1.SetActive(true);
            Wall2.SetActive(true);
            Wall3.SetActive(false);
            Wall4.SetActive(false);

            PicFrameFancy.SetActive(true);
            door.SetActive(true);
            painting1.SetActive(true);
            cupboard1.SetActive(true);
            Puzzle.SetActive(true);
            PS.SetActive(true);
            bed.SetActive(true);
            painting2.SetActive(false);
            plant2.SetActive(true);
            cupboard2.SetActive(true);
            lamp.SetActive(true);
            curtain1.SetActive(false);
            curtain2.SetActive(false);
            mirror.SetActive(false);
            mirrorReflection.SetActive(false);
            painting4.SetActive(true);
            fireplace.SetActive(false);
        }

        // Walls 23
        else if (Camera.main.transform.localEulerAngles.y > 0.0f && Camera.main.transform.localEulerAngles.y < 180.0f)
        {
            Wall1.SetActive(false);
            Wall2.SetActive(true);
            Wall3.SetActive(true);
            Wall4.SetActive(false);

            PicFrameFancy.SetActive(false);
            door.SetActive(false);
            painting1.SetActive(true);
            cupboard1.SetActive(true);
            Puzzle.SetActive(true);
            PS.SetActive(true);
            bed.SetActive(true);
            painting2.SetActive(false);
            plant2.SetActive(true);
            cupboard2.SetActive(true);
            lamp.SetActive(true);
            curtain1.SetActive(true);
            curtain2.SetActive(true);
            mirror.SetActive(true);
            mirrorReflection.SetActive(true);
            painting4.SetActive(true);
            fireplace.SetActive(false);
        }

        // Walls 34
        else if (Camera.main.transform.localEulerAngles.y > 90.0f && Camera.main.transform.localEulerAngles.y < 270.0f)
        {
            Wall1.SetActive(false);
            Wall2.SetActive(false);
            Wall3.SetActive(true);
            Wall4.SetActive(true);

            PicFrameFancy.SetActive(false);
            door.SetActive(false);
            painting1.SetActive(false);
            cupboard1.SetActive(false);
            Puzzle.SetActive(false);
            PS.SetActive(false);
            bed.SetActive(false);
            painting2.SetActive(true);
            plant2.SetActive(false);
            cupboard2.SetActive(false);
            lamp.SetActive(false);
            curtain1.SetActive(true);
            curtain2.SetActive(true);
            mirror.SetActive(true);
            mirrorReflection.SetActive(true);
            painting4.SetActive(false);
            fireplace.SetActive(true);
        }

        // Walls 41
        else
        {
            Wall1.SetActive(true);
            Wall2.SetActive(false);
            Wall3.SetActive(false);
            Wall4.SetActive(true);

            PicFrameFancy.SetActive(true);
            door.SetActive(true);
            painting1.SetActive(false);
            cupboard1.SetActive(false);
            Puzzle.SetActive(false);
            PS.SetActive(false);
            bed.SetActive(false);
            painting2.SetActive(true);
            plant2.SetActive(false);
            cupboard2.SetActive(false);
            lamp.SetActive(false);
            curtain1.SetActive(false);
            curtain2.SetActive(false);
            mirror.SetActive(false);
            mirrorReflection.SetActive(false);
            painting4.SetActive(false);
            fireplace.SetActive(true);
        }
    }
}
