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
            //Sets the pause menu active, and turns off time, so the game is actually paused
            Pausemenu.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            //Sets the pause menu inactive, and turns time back on
            Pausemenu.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
