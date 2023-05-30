using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hints : MonoBehaviour
{
    public GameObject HintLVL1;
    public GameObject HintLVL2;
    public GameObject HintLVL3;
    public GameObject HintLVL4;
    public GameObject HintLVL5;
    public GameObject HintLVL6;
    public GameObject HintPanel;
    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;   
    public GameObject camera4;
    public GameObject camera5;
    public GameObject camera6;
    public GameObject mainMenu;
    public GameObject pauseMenu;
    public GameObject ConfirmMenu;


    // Update is called once per frame
    void Update()
    {
        {
            if (!camera1.activeSelf)
            {
                HintLVL1.SetActive(false);
            }
            if (!camera2.activeSelf)
            {
                HintLVL2.SetActive(false);
            }
             if (!camera3.activeSelf)
            {
                HintLVL3.SetActive(false);
            }
             if (!camera4.activeSelf)
            {
                HintLVL4.SetActive(false);
            }
            if (!camera5.activeSelf)
            {
                HintLVL5.SetActive(false);
            }
            if (!camera6.activeSelf)
            {
                HintLVL6.SetActive(false);
            }
        }
    }
    public void OnButtonPress()
    {
        if (!HintPanel.activeSelf)
        {
            HintPanel.SetActive(true);
            if (camera1.activeSelf)
            {
                HintLVL1.SetActive(true);
            }
            else if (camera2.activeSelf)
            {
                HintLVL2.SetActive(true);
            }
            else if (camera3.activeSelf)
            {
                HintLVL3.SetActive(true);
            }
            else if (camera4.activeSelf)
            {
                HintLVL4.SetActive(true);
            }
            else if (camera5.activeSelf)
            {
                HintLVL5.SetActive(true);
            }
            else if (camera6.activeSelf)
            {
                HintLVL6.SetActive(true);
            }
        }
        
        else if (HintPanel.activeSelf)
        {
            HintPanel.SetActive(false);
        }
    }
}
