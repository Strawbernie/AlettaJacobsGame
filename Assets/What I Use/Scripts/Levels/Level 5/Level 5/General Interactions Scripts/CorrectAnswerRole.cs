using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectAnswerName : MonoBehaviour
{
    public GameObject CorrectAnswer;
    public bool AlettaJacobs;
    private void OnTriggerStay(Collider CorrectAnswer)
    {//check if collision is with specific named thing
        if (CorrectAnswer.name == "JalettaAcobs")
        {
            Debug.Log(true);
            //destroy the rigid body + box collider so it stays so you cant drag it anymore UPDATE NOW CHECK THE PUBLIC BOOLEAN
            AlettaJacobs = true;
            //remove from the comments, add a specific coordinates

        }

    }
    private void OnTriggerExit(Collider Collision)
    {
        if (Collision.gameObject.name == "JalettaAcobs")
        {
            AlettaJacobs = false;
            Debug.Log(false);
        }
    }
}
