using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class DialogueChecker : MonoBehaviour
{
    public FirstTimePassed firstTimePassed;
    public GameObject trigger;

    void Update()
    {
        if (firstTimePassed.firstTimeLevel1 == true)
        {
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == trigger)
                {
                    DialogueManager.StartConversation("Level1BabyConvo");
                    
                }

            }

        }
    }

    // Added by Milan
    public void StartDialogue(string conversationName)
    {
        if (firstTimePassed.firstTimeLevel1 == true)
        {
            // Initiate a wait for seconds before the first dialogue shows up.
            StartCoroutine(DoStartDialogueAfter(2f, conversationName));
        }
    }

    private IEnumerator DoStartDialogueAfter(float time, string conversationName)
    {
        yield return new WaitForSeconds(time);
        DialogueManager.StartConversation(conversationName);
    }
}
