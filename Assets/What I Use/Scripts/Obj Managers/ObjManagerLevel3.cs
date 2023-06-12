using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjManagerLevel3 : MonoBehaviour
{
    // Level's Walls
    public GameObject Wall1;
    public GameObject Wall2;
    public GameObject Wall3;
    public GameObject Wall4;

    // Level's objects
    public GameObject cupboard;
    public GameObject HModel;
    public GameObject poster;
    public GameObject curtain1;
    public GameObject curtain2;
    public GameObject bookshelves;
    public GameObject wCupboard;
    public GameObject clock;
    public GameObject books;
    public GameObject plant;
    public GameObject ParticleSystem;
    public GameObject PSModel;
    public FirstTimePassed firstTimePassed;
    public GameObject board;
    public GameObject pboard;
    public GameObject Door;
    public GameObject classrules;
    public GameObject FBio;
    public GameObject Hanger;
    public GameObject Blackboard;
    public GameObject TDesk;
    public GameObject TDesk2;
    public GameObject TChair;
    public GameObject TBooks;
    public GameObject TApple;
    public GameObject TCloth;

    // Update is called once per frame
    void Update()
    {
        // Wall12
        if (Camera.main.transform.localEulerAngles.y > -90.0f && Camera.main.transform.localEulerAngles.y < 90.0f)
        {
            Wall1.SetActive(true);
            Wall2.SetActive(true);
            Wall3.SetActive(false);
            Wall4.SetActive(false);

            FBio.SetActive(true);
            Door.SetActive(true);
            Hanger.SetActive(true);
            board.SetActive(true);
            pboard.SetActive(true);
            classrules.SetActive(true);
            Blackboard.SetActive(true);
            TDesk.SetActive(true); 
            TDesk2.SetActive(true);
            TChair.SetActive(true);
            TBooks.SetActive(true);
            TApple.SetActive(true);
            TCloth.SetActive(true);
            cupboard.SetActive(true);
            ParticleSystem.SetActive(true);
            HModel.SetActive(false);
            PSModel.SetActive(false);
            poster.SetActive(false);
            curtain1.SetActive(false);
            curtain2.SetActive(false);
            bookshelves.SetActive(false);
            clock.SetActive(false);
            books.SetActive(false);
            wCupboard.SetActive(false);
            plant.SetActive(false);
            if (firstTimePassed.firstTimeLevel3)
                {
                ParticleSystem.SetActive(true);
            }
        }

        // Wall23
        else if (Camera.main.transform.localEulerAngles.y > 0.0f && Camera.main.transform.localEulerAngles.y < 180.0f)
        {
            Wall1.SetActive(false);
            Wall2.SetActive(true);
            Wall3.SetActive(true);
            Wall4.SetActive(false);

            FBio.SetActive(false);
            Door.SetActive(false);
            Hanger.SetActive(false);
            board.SetActive(false);
            pboard.SetActive(false);
            classrules.SetActive(false);
            Blackboard.SetActive(true);
            TDesk.SetActive(true);
            TDesk2.SetActive(true);
            TChair.SetActive(true);
            TBooks.SetActive(true);
            TApple.SetActive(true);
            TCloth.SetActive(true);
            cupboard.SetActive(true);
            ParticleSystem.SetActive(true);
            HModel.SetActive(false);
            PSModel.SetActive(false);
            poster.SetActive(false);
            curtain1.SetActive(true);
            curtain2.SetActive(true);
            bookshelves.SetActive(false);
            clock.SetActive(false);
            books.SetActive(false);
            wCupboard.SetActive(false);
            plant.SetActive(false);
        }

        // Wall34
        else if (Camera.main.transform.localEulerAngles.y > 90.0f && Camera.main.transform.localEulerAngles.y < 270.0f)
        {
            Wall1.SetActive(false);
            Wall2.SetActive(false);
            Wall3.SetActive(true);
            Wall4.SetActive(true);

            FBio.SetActive(false);
            Door.SetActive(false);
            Hanger.SetActive(false);
            board.SetActive(false);
            pboard.SetActive(false);
            classrules.SetActive(false);
            Blackboard.SetActive(false);
            TDesk.SetActive(false);
            TDesk2.SetActive(false);
            TChair.SetActive(false);
            TBooks.SetActive(false);
            TApple.SetActive(false);
            TCloth.SetActive(false);
            cupboard.SetActive(false);
            ParticleSystem.SetActive(false);
            HModel.SetActive(true);
            PSModel.SetActive(true);
            poster.SetActive(true);
            curtain1.SetActive(true);
            curtain2.SetActive(true);
            bookshelves.SetActive(true);
            clock.SetActive(true);
            books.SetActive(true);
            wCupboard.SetActive(true);
            plant.SetActive(true);
        }

        // Wall41
        else
        {
            Wall1.SetActive(true);
            Wall2.SetActive(false);
            Wall3.SetActive(false);
            Wall4.SetActive(true);

            FBio.SetActive(true);
            Door.SetActive(true);
            Hanger.SetActive(true);
            board.SetActive(true);
            pboard.SetActive(true);
            classrules.SetActive(true);
            Blackboard.SetActive(false);
            TDesk.SetActive(false);
            TDesk2.SetActive(false);
            TChair.SetActive(false);
            TBooks.SetActive(false);
            TApple.SetActive(false);
            TCloth.SetActive(false);
            cupboard.SetActive(false);
            ParticleSystem.SetActive(false);
            HModel.SetActive(true);
            PSModel.SetActive(true);
            poster.SetActive(true); 
            curtain1.SetActive(false);
            curtain2.SetActive(false);
            bookshelves.SetActive(true);
            clock.SetActive(true);
            books.SetActive(true);
            wCupboard.SetActive(true);
            plant.SetActive(true);
            if (firstTimePassed.firstTimeLevel3)
            {
                ParticleSystem.SetActive(true);
            }
        }
    }
}
