using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectAnswerDate : MonoBehaviour
{
    public GameObject CorrectAnswer;
    public bool February;
    private void OnTriggerStay(Collider CorrectAnswer)
    {//check if collision is with specific named thing
        if (CorrectAnswer.name == "YePlaceForCorrectDate")
        {
            Debug.Log(true);
            //destroy the rigid body + box collider so it stays so you cant drag it anymore UPDATE NOW CHECK THE PUBLIC BOOLEAN
            February = true;
            //remove from the comments, add a specific coordinates

        }

    }
    private void OnTriggerExit(Collider Collision)
    {
        if (Collision.gameObject.name == "YePlaceForCorrectDate")
        {
            February = false;
            Debug.Log(false);
        }
    }
}
