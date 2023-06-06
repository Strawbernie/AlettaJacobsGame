using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Correct4 : MonoBehaviour
{
    public DisabledMode disabledMode;
    public FirstTimePassed firstTimePassed;
    public GameObject camera4;
    public GameObject camera5;
    public GameObject UpButton;
    public GameObject DownButton;
    public GameObject HandIn;

    Animator animator;
    public GameObject levelChanger;

    public GameObject C1;
    public GameObject C2;
    public GameObject C3;
    public GameObject C4;
    public GameObject ParticleSystem;
    public GameObject HintPanel;

    //Reset answers
    public GameObject C2A;
    public GameObject C3A;
    public GameObject C4A;
    public GameObject C1B;
    public GameObject C3B;
    public GameObject C4B;
    public GameObject C1C;
    public GameObject C2C;
    public GameObject C4C;
    public GameObject C2D;
    public GameObject C3D;
    public GameObject C4D;

    // Boolean that will allow the code to detect touch
    public bool objectTapDetectorActive = true;

    private IEnumerator EnableStuffAfterDelay()
    {
        yield return new WaitForSeconds(1f);
        disabledMode.goBackDisabled = true;
        disabledMode.swipeDisabled = false;
        Destroy(ParticleSystem);
        camera4.SetActive(false);
        camera5.SetActive(true);
        HandIn.SetActive(false);
        UpButton.SetActive(false);
        DownButton.SetActive(false);
    }

    public void Start()
    {
        animator = levelChanger.GetComponent<Animator>();
    }

    // Update is called once per frame
    public void OnButtonPress()
    {
        if (firstTimePassed.firstTimeLevel4)
        {
            if (objectTapDetectorActive)
            {
                if (C1.activeSelf && C2.activeSelf && C3.activeSelf && C4.activeSelf)
                {
                    firstTimePassed.firstTimeLevel4 = false;
                    animator.SetTrigger("FadeOut");
                    StartCoroutine(EnableStuffAfterDelay());
                    HintPanel.SetActive(false);
                }
                else
                {
                    C1.SetActive(false);
                    C2.SetActive(false);
                    C3.SetActive(false);
                    C4.SetActive(false);
                    C2A.SetActive(false);
                    C3A.SetActive(false);
                    C4A.SetActive(false);
                    C1B.SetActive(false);
                    C3B.SetActive(false);
                    C4B.SetActive(false);
                    C1C.SetActive(false);
                    C2C.SetActive(false);
                    C4C.SetActive(false);
                    C2D.SetActive(false);
                    C3D.SetActive(false);
                    C4D.SetActive(false);
                }
            }
        }
    }
}
