using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject pauseMenu;
    public GameObject confirmMenu;
    public GameObject HintButton;
    public GameObject hintPanel;
    public GameObject TargetHint;
    public GameObject camera7;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (!mainMenu.activeSelf && !pauseMenu.activeSelf && !confirmMenu.activeSelf && !camera7.activeSelf)
        {
            HintButton.SetActive(true);
        }
        else
        {
            HintButton.SetActive(false);
        }
    }
    public void OnButtonPress()
    {
        hintPanel.SetActive(false);
        TargetHint.SetActive(false);
    }
}
