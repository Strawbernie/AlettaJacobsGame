using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LevelCovers : MonoBehaviour
{
    public GameObject levelCover4;
    public GameObject levelCover5;
    public GameObject levelCover6;

    public GameObject timelineImage;

    public FirstTimePassed firstTimePassed;
    // Start is called before the first frame update
    void Start()
    {
        levelCover4.SetActive(false);
        levelCover5.SetActive(false);
        levelCover6.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (timelineImage.activeSelf)
        {
            if (!firstTimePassed.firstTimeLevel3)
            {
                levelCover4.SetActive(false);
                levelCover5.SetActive(true);
                levelCover6.SetActive(true);

                if (!firstTimePassed.firstTimeLevel4)
                {
                    levelCover4.SetActive(false);
                    levelCover5.SetActive(false);
                    levelCover6.SetActive(true);
                    if (!firstTimePassed.firstTimeLevel5)
                    {
                        levelCover4.SetActive(false);
                        levelCover5.SetActive(false);
                        levelCover6.SetActive(false);
                    }
                }
            }
            else
            {
                levelCover4.SetActive(true);
                levelCover5.SetActive(true);
                levelCover6.SetActive(true);
            }
        }
        else
        {
            levelCover4.SetActive(false);
            levelCover5.SetActive(false);
            levelCover6.SetActive(false);
        }
    }
}
