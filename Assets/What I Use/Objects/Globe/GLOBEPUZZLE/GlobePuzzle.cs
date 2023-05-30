using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobePuzzle : MonoBehaviour
{
    public GameObject FlagToActivate;
    public GameObject ButtonToActivate;
    public GameObject ButtonToDisable;
    public GameObject WinCheck;
    //public GameObject globeCamera;
    public bool objectTapDetectorActive = true;
    public GameObject HintPanel;
    // Start is called before the first frame update


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {
        if (objectTapDetectorActive)
        {
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == ButtonToDisable)
                {
                    if (ButtonToDisable.activeSelf)
                    {
                        FlagToActivate.SetActive(true);
                        ButtonToActivate.SetActive(true);
                        ButtonToDisable.SetActive(false);
                    }

                    if (WinCheck.activeSelf)
                    {
                        HintPanel.SetActive(false);
                    }
                }

            }
        }
    }
}

