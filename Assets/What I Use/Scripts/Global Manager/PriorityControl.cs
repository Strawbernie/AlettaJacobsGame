using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriorityControl : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject pauseMenu;
    public GameObject Confirmmenu;
    public GameObject Level1;
    public GameObject Level2;
    public GameObject Level3;
    public GameObject Level4;
    public GameObject Level5;
    public GameObject Level6;
    public GameObject Level7;
    public GameObject LVL6Text;

    // Update is called once per frame
    void Update()
    {
        if (!MainMenu.activeSelf && !pauseMenu.activeSelf && !Confirmmenu.activeSelf && !LVL6Text.activeSelf)
        {
            Level1.SetActive(true);
            Level2.SetActive(true);
            Level3.SetActive(true);
            Level4.SetActive(true);
            Level5.SetActive(true);
            Level6.SetActive(true);
            Level7.SetActive(true);
        }
        else
        {
            Level1.SetActive(false);
            Level2.SetActive(false);
            Level3.SetActive(false);
            Level4.SetActive(false);
            Level5.SetActive(false);
            Level6.SetActive(false);
            Level7.SetActive(false);
        }
    }
}
