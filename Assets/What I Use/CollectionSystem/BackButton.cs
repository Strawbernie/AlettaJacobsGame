using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    public GameObject mainScreen;
    public GameObject colScreen;
    // Start is called before the first frame update
    public void OnButtonPress()
    {
        mainScreen.SetActive(true);
        colScreen.SetActive(false);
    }
}
