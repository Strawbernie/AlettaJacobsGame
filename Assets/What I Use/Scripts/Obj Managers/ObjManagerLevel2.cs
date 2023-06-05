using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjManagerLevel2 : MonoBehaviour
{
    // Level's objects
    public GameObject door;
    public GameObject painting1;
    public GameObject cupboard;
    public GameObject painting2;
    public GameObject book;
    public GameObject chair;
    public GameObject desk;
    public GameObject books;
    public GameObject pen;
    public GameObject ink;
    public GameObject painting3;
    public GameObject curtains2;
    public GameObject quack;
    public GameObject bed;
    public GameObject blueBook;
    public GameObject brownBook;
    public GameObject greenBook;
    public GameObject suitcase;
    public GameObject bedTable;
    public GameObject KeyParticleSystem;
    public GameObject Key;
    public GameObject Pills;
    public GameObject PSPills;
    public GameObject Lamp;

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
            Wall1.SetActive(false);
            Wall2.SetActive(false);
            Wall3.SetActive(true);
            Wall4.SetActive(true);
            curtains2.SetActive(false);
            door.SetActive(true);
            painting1.SetActive(true);
            cupboard.SetActive(true);
            Pills.SetActive(true);
            PSPills.SetActive(true);
            painting2.SetActive(true);
            book.SetActive(true);
            chair.SetActive(false);
            KeyParticleSystem.SetActive(false);
            Key.SetActive(false);
            desk.SetActive(false);
            books.SetActive(false);
            pen.SetActive(false);
            ink.SetActive(false);
            painting3.SetActive(false);
            bedTable.SetActive(false);
            Lamp.SetActive(false);
        }

        // Walls 23
        else if (Camera.main.transform.localEulerAngles.y > 0.0f && Camera.main.transform.localEulerAngles.y < 180.0f)
        {
            Wall1.SetActive(true);
            Wall2.SetActive(false);
            Wall3.SetActive(false);
            Wall4.SetActive(true);
            curtains2.SetActive(true);
            door.SetActive(false);
            painting1.SetActive(true);
            cupboard.SetActive(true);
            Pills.SetActive(true);
            PSPills.SetActive(true);
            painting2.SetActive(false);
            book.SetActive(true);
            chair.SetActive(true);
            KeyParticleSystem.SetActive(true);
            Key.SetActive(true);
            desk.SetActive(true);
            books.SetActive(true);
            pen.SetActive(true);
            ink.SetActive(true);
            painting3.SetActive(false);
            bedTable.SetActive(false);
            Lamp.SetActive(false);
        }

        // Walls 34
        else if (Camera.main.transform.localEulerAngles.y > 90.0f && Camera.main.transform.localEulerAngles.y < 270.0f)
        {
            Wall1.SetActive(true);
            Wall2.SetActive(true);
            Wall3.SetActive(false);
            Wall4.SetActive(false);
            curtains2.SetActive(true);
            door.SetActive(false);
            painting1.SetActive(false);
            cupboard.SetActive(false);
            Pills.SetActive(false);
            PSPills.SetActive(false);
            painting2.SetActive(false);
            book.SetActive(false); 
            chair.SetActive(true);
            KeyParticleSystem.SetActive(true);
            Key.SetActive(true);
            desk.SetActive(true);
            books.SetActive(true);
            pen.SetActive(true);
            ink.SetActive(true);
            painting3.SetActive(true);
            bedTable.SetActive(true);
            Lamp.SetActive(true);
        }

        // Walls 41
        else
        {
            Wall1.SetActive(false);
            Wall2.SetActive(true);
            Wall3.SetActive(true);
            Wall4.SetActive(false);
            curtains2.SetActive(false);
            door.SetActive(true);
            painting1.SetActive(false);
            cupboard.SetActive(false);
            Pills.SetActive(false);
            PSPills.SetActive(false);
            painting2.SetActive(true);
            book.SetActive(false);
            chair.SetActive(false);
            KeyParticleSystem.SetActive(false);
            Key.SetActive(false);
            desk.SetActive(false);
            books.SetActive(false);
            pen.SetActive(false);
            ink.SetActive(false);
            painting3.SetActive(true);
            bedTable.SetActive(true);
            Lamp.SetActive(true);
        }
    }
}