using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeGame : MonoBehaviour
{
    public GameObject Cog;
    public GameObject pauseMenu;
    // Start is called before the first frame update
    public void OnButtonPress()
    {
        Cog.SetActive(true);
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
}
