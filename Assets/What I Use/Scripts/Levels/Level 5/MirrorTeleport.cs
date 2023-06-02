using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MirrorTeleport : MonoBehaviour
{
    public GameObject camera5;
    public GameObject camera6;

    public GameObject levelChanger;
    public DisabledMode disabledMode;
    public FirstTimePassed firstTimePassed;
    public CorrectAnswerCountry country;
    public CorrectAnswerName Name;
    public CorrectAnswerDate date;
    public CorrectAnswerRole role;
    // Start is called before the first frame update
    private IEnumerator EnableStuffAfterDelay()
    {
        yield return new WaitForSeconds(1f);
        disabledMode.goBackDisabled = true;
        disabledMode.swipeDisabled = false;
        camera5.SetActive(false);
        camera6.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (country.Nederland && Name.CorrectName && date.February && role.AlettaJacobs)
            {
                StartCoroutine(EnableStuffAfterDelay());
            }
        }
    }
