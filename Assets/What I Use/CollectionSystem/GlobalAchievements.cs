using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAchievements : MonoBehaviour
{
    //Global Variables
    public GameObject achNote;
    public bool achActive = false;
    public GameObject achTitle;
    public GameObject achDesc;

    //Specific Variables
    public GameObject achImage;
    public GameObject achievement; //the achievement in collection screen
    public static int achCount;
    public int achTrigger = 1;
    public int achCode;
    // Update is called once per frame
    void Update()
    {
        achCode = PlayerPrefs.GetInt("Ach");
        if (achCount == achTrigger && achCode != 1)
        {
            StartCoroutine(TriggerAch());
        }
    }
    IEnumerator TriggerAch()
    {
        achActive = true;
        achCode = 1;
        PlayerPrefs.SetInt("Ach", achCode);
        achImage.SetActive(true);
        achTitle.GetComponent<Text>().text = "Collection!";
        achDesc.GetComponent<Text>().text = "Gotten a achievement";
        achNote.SetActive(true);
        yield return new WaitForSeconds(5);
        //Resetting UI
        achNote.SetActive(false);
        achImage.SetActive(false);
        achTitle.GetComponent<Text>().text = "";
        achDesc.GetComponent<Text>().text = "";
        achievement.SetActive(true);
        achActive = false;
    }
}
