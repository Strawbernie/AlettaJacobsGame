using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjManagerLevel3 : MonoBehaviour
{
    // Level's Walls
    public GameObject Wall1;
    public GameObject Wall2;

    // Level's objects
    public GameObject cupboard;
    public GameObject display;
    public GameObject HModel;
    public GameObject poster;
    public GameObject glass;
    public GameObject curtain1;
    public GameObject curtain2;
    public GameObject bookshelves;
    public GameObject plant;
    public GameObject objectsOnDisplay;
    public GameObject ParticleSystem;

    // Update is called once per frame
    void Update()
    {
        // Wall12
        if (Camera.main.transform.localEulerAngles.y > -90.0f && Camera.main.transform.localEulerAngles.y < 90.0f)
        {
            Wall1.SetActive(true);
            Wall2.SetActive(true);

            cupboard.SetActive(true);
            ParticleSystem.SetActive(true);
            display.SetActive(true);
            HModel.SetActive(true);
            poster.SetActive(true);
            glass.SetActive(true);
            curtain1.SetActive(true);
            curtain2.SetActive(true);
            objectsOnDisplay.SetActive(true);
            bookshelves.SetActive(true);
            plant.SetActive(true);
        }

        // Wall23
        else if (Camera.main.transform.localEulerAngles.y > 0.0f && Camera.main.transform.localEulerAngles.y < 180.0f)
        {
            Wall1.SetActive(false);
            Wall2.SetActive(true);

            cupboard.SetActive(false);
            ParticleSystem.SetActive(false);
            display.SetActive(false);
            HModel.SetActive(false);
            poster.SetActive(false);
            glass.SetActive(false);
            curtain1.SetActive(false);
            curtain2.SetActive(false);
            objectsOnDisplay.SetActive(false);
            bookshelves.SetActive(true);
            plant.SetActive(true);
        }

        // Wall34
        else if (Camera.main.transform.localEulerAngles.y > 90.0f && Camera.main.transform.localEulerAngles.y < 270.0f)
        {
            Wall1.SetActive(false);
            Wall2.SetActive(false);

            cupboard.SetActive(false);
            ParticleSystem.SetActive(false);
            display.SetActive(false);
            HModel.SetActive(false);
            poster.SetActive(false);
            glass.SetActive(false);
            curtain1.SetActive(false);
            curtain2.SetActive(false);
            objectsOnDisplay.SetActive(false);
            bookshelves.SetActive(false);
            plant.SetActive(false);
        }

        // Wall41
        else
        {
            Wall1.SetActive(true);
            Wall2.SetActive(false);

            cupboard.SetActive(true);
            ParticleSystem.SetActive(true);
            display.SetActive(true);
            HModel.SetActive(true);
            poster.SetActive(true); 
            glass.SetActive(true);
            curtain1.SetActive(true);
            curtain2.SetActive(true);
            objectsOnDisplay.SetActive(true);
            bookshelves.SetActive(false);
            plant.SetActive(false);
        }
    }
}
