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
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {

                StartCoroutine(EnableStuffAfterDelay());
            }
        }
    }
}
