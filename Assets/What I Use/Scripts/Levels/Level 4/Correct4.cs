using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Correct4 : MonoBehaviour
{
    public DisabledMode disabledMode;
    public FirstTimePassed firstTimePassed;
    public GameObject camera4;
    public GameObject camera5;

    Animator animator;
    public GameObject levelChanger;

    public GameObject setTrue;
    public GameObject setFalse;
    public GameObject setFalse1;
    public GameObject setFalse2;
    public GameObject C1;
    public GameObject C2;
    public GameObject C3;
    public GameObject C4;
    public GameObject Button;
    public GameObject ParticleSystem;
    public GameObject HintPanel;
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
    }

    public void Start()
    {
        animator = levelChanger.GetComponent<Animator>();
    }

    // Update is called once per frame
    public void Update()
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

                if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
                {
                    Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                    RaycastHit hit;

                    if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == Button)
                    {
                        setTrue.SetActive(true);
                        setFalse.SetActive(false);
                        setFalse1.SetActive(false);
                        setFalse2.SetActive(false);
                    }
                }
            }
        }
    }
}
