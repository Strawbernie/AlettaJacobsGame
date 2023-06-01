using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjManagerLevel1 : MonoBehaviour
{
    // Level's objects
    public GameObject door;
    public GameObject painting1;
    public GameObject painting2;
    public GameObject cupboard;
    public GameObject doll2;
    public GameObject chair;
    public GameObject clothes2;
    public GameObject plant;
    public GameObject painting3;
    public GameObject curtains;
    public GameObject painting4;
    public GameObject quack;
    public GameObject table;
    public GameObject shelves;
    public GameObject clothes4;
    public GameObject books;
    public GameObject doll4;
    public GameObject bear;
    public GameObject yula;
    public GameObject cubes;
    public GameObject cubes2;
    public GameObject cubes3;
    public GameObject babyBottle;
    public GameObject ParticleSystem;
    public GameObject newspaper;

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

            door.SetActive(true);
            painting1.SetActive(true);
            painting2.SetActive(true);
            cupboard.SetActive(true);
            doll2.SetActive(true);
            newspaper.SetActive(true);
            chair.SetActive(true);
            clothes2.SetActive(true);
            plant.SetActive(true);
            painting3.SetActive(false);
            curtains.SetActive(false);
            painting4.SetActive(false);
            quack.SetActive(false);
            table.SetActive(false);
            shelves.SetActive(false);
            clothes4.SetActive(false);
            books.SetActive(false);
            doll4.SetActive(false);
            bear.SetActive(false);
            yula.SetActive(false);
            cubes.SetActive(false);
            cubes2.SetActive(false);
            cubes3.SetActive(false);
            babyBottle.SetActive(false);
        }

        // Walls 23
        else if (Camera.main.transform.localEulerAngles.y > 0.0f && Camera.main.transform.localEulerAngles.y < 180.0f)
        {
            Wall1.SetActive(false);
            Wall2.SetActive(true);
            Wall3.SetActive(true);
            Wall4.SetActive(false);

            door.SetActive(false);
            painting1.SetActive(false);
            painting2.SetActive(true);
            cupboard.SetActive(true);
            doll2.SetActive(true);
            newspaper.SetActive(true);
            chair.SetActive(true);
            clothes2.SetActive(true);
            plant.SetActive(true);
            painting3.SetActive(true);
            curtains.SetActive(true);
            painting4.SetActive(false);
            quack.SetActive(false);
            table.SetActive(false);
            shelves.SetActive(false);
            clothes4.SetActive(false);
            books.SetActive(false);
            doll4.SetActive(false);
            bear.SetActive(false);
            yula.SetActive(false);
            cubes.SetActive(false);
            cubes2.SetActive(false);
            cubes3.SetActive(false);
            babyBottle.SetActive(false);
        }

        // Walls 34
        else if (Camera.main.transform.localEulerAngles.y > 90.0f && Camera.main.transform.localEulerAngles.y < 270.0f)
        {
            Wall1.SetActive(false);
            Wall2.SetActive(false);
            Wall3.SetActive(true);
            Wall4.SetActive(true);

            door.SetActive(false);
            painting1.SetActive(false);
            painting2.SetActive(false);
            cupboard.SetActive(false);
            doll2.SetActive(false);
            newspaper.SetActive(false);
            chair.SetActive(false);
            clothes2.SetActive(false);
            plant.SetActive(false);
            painting3.SetActive(true);
            curtains.SetActive(true);
            painting4.SetActive(true);
            quack.SetActive(true);
            table.SetActive(true);
            shelves.SetActive(true);
            clothes4.SetActive(true);
            books.SetActive(true);
            doll4.SetActive(true);
            bear.SetActive(true);
            yula.SetActive(true);
            cubes.SetActive(true);
            cubes2.SetActive(true);
            cubes3.SetActive(true);
            babyBottle.SetActive(true);
        }

        // Walls 41
        else
        {
            Wall1.SetActive(true);
            Wall2.SetActive(false);
            Wall3.SetActive(false);
            Wall4.SetActive(true);

            door.SetActive(true);
            painting1.SetActive(true);
            painting2.SetActive(false);
            cupboard.SetActive(false);
            doll2.SetActive(false);
            newspaper.SetActive(false);
            chair.SetActive(false);
            clothes2.SetActive(false);
            plant.SetActive(false);
            painting3.SetActive(false);
            curtains.SetActive(false);
            painting4.SetActive(true);
            quack.SetActive(true);
            table.SetActive(true);
            shelves.SetActive(true);
            clothes4.SetActive(true);
            books.SetActive(true);
            doll4.SetActive(true);
            bear.SetActive(true);
            yula.SetActive(true);
            cubes.SetActive(true);
            cubes2.SetActive(true);
            cubes3.SetActive(true);
            babyBottle.SetActive(true);
        }
    }
}
