using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectAnswerCountry : MonoBehaviour
{ public GameObject CorrectAnswer;
    public bool Nederland;
    private void OnTriggerStay(Collider CorrectAnswer )
    {//check if collision is with specific named thing
        if (CorrectAnswer.name == "DeNederland")
        {
            Debug.Log(true);
            //destroy the rigid body + box collider so it stays so you cant drag it anymore UPDATE NOW CHECK THE PUBLIC BOOLEAN
            Nederland = true;
            //remove from the comments, add a specific coordinates POSIIBLE AT THE END!

        }
        
    }
    private void OnTriggerExit(Collider Collision)
    { if (Collision.gameObject.name == "DeNederland")
        Nederland = false;
        Debug.Log(false);
    }
}
