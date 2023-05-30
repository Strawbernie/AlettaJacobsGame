using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

/// <summary>
/// The code will check if the player plays level 2 for the first time,
/// if they do - it will check if all the books were put into the suitcase.
/// If they were - it will send the player to the next level
/// </summary>

public class SuitcasePuzzle : MonoBehaviour
{
    public bool allBooksIn;

    public GameObject blueBook;
    public GameObject greenBook;
    public GameObject brownBook;

    public GameObject camera2;
    public GameObject camera3;
    public GameObject swipeDetector;

    Animator anim;
    public GameObject suitcase;
    Animator animator;
    public GameObject levelChanger;

    public ObjAnim suitcaseAnim;

    public DragAndDrop booksScript;

    private bool blueBookInside = false;
    private bool greenBookInside = false;
    private bool brownBookInside = false;

    public FirstTimePassed firstTimePassed;
    public DisabledMode disabledMode;
    public GameObject HintPanel;

    private IEnumerator EnableStuffAfterDelay()
    {
        yield return new WaitForSeconds(1f);
        disabledMode.goBackDisabled = true;
        disabledMode.swipeDisabled = false;
        camera2.SetActive(false);
        camera3.SetActive(true);
        HintPanel.SetActive(false);
    }

    private void Start()
    {
        animator = levelChanger.GetComponent<Animator>();
        anim = suitcase.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == blueBook)
        {
            blueBookInside = true;
        }
        else if (other.gameObject == greenBook)
        {
            greenBookInside = true;
        }
        else if (other.gameObject == brownBook)
        {
            brownBookInside = true;
        }

        if (firstTimePassed.firstTimeLevel2)
        {
            if (blueBookInside && greenBookInside && brownBookInside)
            {
                allBooksIn = true;
                firstTimePassed.firstTimeLevel2 = false;
                anim.SetTrigger("TrZoomOut");
                suitcaseAnim.isOpen = false;
                animator.SetTrigger("FadeOut");
                HintPanel.SetActive(false);
                StartCoroutine(EnableStuffAfterDelay());
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == blueBook)
        {
            blueBookInside = false;
        }
        else if (other.gameObject == greenBook)
        {
            greenBookInside = false;
        }
        else if (other.gameObject == brownBook)
        {
            brownBookInside = false;
        }
    }
}
