using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject pauseMenu;
    public GameObject confirmMenu;
    public GameObject HintButton;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (!mainMenu.activeSelf && !pauseMenu.activeSelf && !confirmMenu.activeSelf)
        {
            HintButton.SetActive(true);
        }
        else
        {
            HintButton.SetActive(false);
        }
    }
}
