using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectAnswerRole : MonoBehaviour
{
    public GameObject CorrectAnswer;
    public bool CorrectName;
    public void OnTriggerStay(Collider CorrectAnswer)
    {//check if collision is with specific named thing
        if (CorrectAnswer.name == "JalettaAcobs")
        {
            Debug.Log(true);
            //destroy the rigid body + box collider so it stays so you cant drag it anymore UPDATE NOW CHECK THE PUBLIC BOOLEAN
            CorrectName = true;
            //remove from the comments, add a specific coordinates

        }

    }
    public void OnTriggerExit(Collider Collision)
    {
        if (Collision.gameObject.name == "JalettaAcobs")
        {
            CorrectName = false;
            Debug.Log(false);
        }
    }
}
