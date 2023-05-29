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
        if (!MainMenu.activeSelf) 
        {
            Cog.SetActive(true);
        }
    }
    
    public void Onpress()
    {
        Pausemenu.SetActive(true);
    }
}
