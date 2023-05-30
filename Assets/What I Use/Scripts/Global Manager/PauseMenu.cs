using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject Pausemenu;
    public GameObject MainMenu;
    public GameObject Cog;

    // Update is called once per frame
    void Update()
    {
        if (!MainMenu.activeSelf || !Pausemenu.activeSelf) 
        {
            Cog.SetActive(true);
        }
    }
    
    public void Onpress()
    {
        if (!Pausemenu.activeSelf)
        {
            Pausemenu.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            Pausemenu.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
