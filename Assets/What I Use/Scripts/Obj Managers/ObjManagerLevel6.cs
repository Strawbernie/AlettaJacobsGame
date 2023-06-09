using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjManagerLevel6 : MonoBehaviour
{
    // Level's objects
    public GameObject painting1;
    public GameObject sphere;
    public GameObject holder;
    public GameObject shelf;
    public GameObject plane;
    public GameObject ship;
    public GameObject curtain;
    public GameObject painting3;
    public GameObject poster;
    public GameObject desk;
    public GameObject quack;
    public GameObject pen;
    public GameObject lamp;
    public GameObject book;
    public GameObject plant;
    public GameObject chair;
    public GameObject door;
    public GameObject painting4;
    public GameObject ParticleSystem;
    public GameObject painting2;
    public GameObject paper;
    public GameObject plant2;
    public GameObject PSDesk;

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

            ParticleSystem.SetActive(false);
            painting1.SetActive(true);
            sphere.SetActive(true);
            holder.SetActive(true);
            shelf.SetActive(true);
            plant2.SetActive(true);
            plane.SetActive(true);
            ship.SetActive(true);
            curtain.SetActive(true);
            painting3.SetActive(false);
            painting2.SetActive(false);
            poster.SetActive(false);
            desk.SetActive(false);
            PSDesk.SetActive(false);
            paper.SetActive(false);
            quack.SetActive(false);
            pen.SetActive(false);
            lamp.SetActive(false);
            book.SetActive(false);
            plant.SetActive(false);
            chair.SetActive(false);
            door.SetActive(false);
            painting4.SetActive(false);
        }

        // Walls 23
        else if (Camera.main.transform.localEulerAngles.y > 0.0f && Camera.main.transform.localEulerAngles.y < 180.0f)
        {
            Wall1.SetActive(false);
            Wall2.SetActive(true);
            Wall3.SetActive(true);
            Wall4.SetActive(false);

            ParticleSystem.SetActive(true);
            painting1.SetActive(false);
            sphere.SetActive(true);
            holder.SetActive(true); 
            shelf.SetActive(true);
            plant2.SetActive(true);
            plane.SetActive(true);
            ship.SetActive(true);
            curtain.SetActive(true);
            painting3.SetActive(true);
            painting2.SetActive(true);
            poster.SetActive(true);
            desk.SetActive(true);
            PSDesk.SetActive(true);
            paper.SetActive(true);
            quack.SetActive(true);
            pen.SetActive(true);
            lamp.SetActive(true);
            book.SetActive(true);
            plant.SetActive(true);
            chair.SetActive(true);
            door.SetActive(false);
            painting4.SetActive(false);
        }

        // Walls 34
        else if (Camera.main.transform.localEulerAngles.y > 90.0f && Camera.main.transform.localEulerAngles.y < 270.0f)
        {
            Wall1.SetActive(false);
            Wall2.SetActive(false);
            Wall3.SetActive(true);
            Wall4.SetActive(true);

            ParticleSystem.SetActive(false);
            painting1.SetActive(false);
            sphere.SetActive(false);
            holder.SetActive(false);
            shelf.SetActive(false);
            plant2.SetActive(false);
            plane.SetActive(false);
            ship.SetActive(false);
            curtain.SetActive(false);
            painting3.SetActive(true);
            painting2.SetActive(true);
            poster.SetActive(true);
            desk.SetActive(true);
            PSDesk.SetActive(true);
            paper.SetActive(true);
            quack.SetActive(true);
            pen.SetActive(true);
            lamp.SetActive(true);
            book.SetActive(true);
            plant.SetActive(true);
            chair.SetActive(true);
            door.SetActive(true);
            painting4.SetActive(true);
        }

        // Walls 41
        else
        {
            Wall1.SetActive(true);
            Wall2.SetActive(false);
            Wall3.SetActive(false);
            Wall4.SetActive(true);

            ParticleSystem.SetActive(false);
            painting1.SetActive(true);
            sphere.SetActive(false);
            shelf.SetActive(false);
            plant2.SetActive(false);
            holder.SetActive(false);
            plane.SetActive(false);
            ship.SetActive(false);
            curtain.SetActive(false);
            painting3.SetActive(false);
            painting2.SetActive(false);
            poster.SetActive(false);
            desk.SetActive(false);
            PSDesk.SetActive(false);
            paper.SetActive(false);
            quack.SetActive(false);
            pen.SetActive(false);
            lamp.SetActive(false);
            book.SetActive(false);
            plant.SetActive(false);
            chair.SetActive(false);
            door.SetActive(true);
            painting4.SetActive(true);
        }
    }
}
