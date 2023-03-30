using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SuitcasePuzzle : MonoBehaviour
{
    bool item1 = false;
    bool item2 = false;
   

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Buba");
        if (item1 == false)
        {
            item1 = true;
        }
        else if (item1  == true && item2 == false)
        {
            item2 = true;
        }
        else if (item1 == true && item2 == true)
        {
            SceneManager.LoadScene(0);
        }
    }
} 