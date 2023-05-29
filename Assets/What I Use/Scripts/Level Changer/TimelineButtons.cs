using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimelineButtons : MonoBehaviour
{
    public GameObject timelineImage;
    public Button clock;
    public Button level1;
    public Button level2;
    public Button level3;
    public Button level4;
    public Button level5;
    public Button level6;

    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;
    public GameObject camera4;
    public GameObject camera5;
    public GameObject camera6;

    public FirstTimePassed firstTimePassed;

    private Color lightGrey;
    private Color blueButton;

    private GameObject levelChanger;
    Animator anim;
    public GameObject SwipeTutorial;

    private bool isActive = false;

    private IEnumerator EnableStuffAfterDelay1()
    {
        yield return new WaitForSeconds(1f);
        camera1.SetActive(true);
        camera2.SetActive(false);
        camera3.SetActive(false);
        camera4.SetActive(false);
        camera5.SetActive(false);
        camera6.SetActive(false);
    }

    private IEnumerator EnableStuffAfterDelay2()
    {
        yield return new WaitForSeconds(1f);
        camera1.SetActive(false);
        camera2.SetActive(true);
        camera3.SetActive(false);
        camera4.SetActive(false);
        camera5.SetActive(false);
        camera6.SetActive(false);
        SwipeTutorial.SetActive(true);
    }

    private IEnumerator EnableStuffAfterDelay3()
    {
        yield return new WaitForSeconds(1f);
        camera1.SetActive(false);
        camera2.SetActive(false);
        camera3.SetActive(true);
        camera4.SetActive(false);
        camera5.SetActive(false);
        camera6.SetActive(false);
    }

    private IEnumerator EnableStuffAfterDelay4()
    {
        yield return new WaitForSeconds(1f);
        camera1.SetActive(false);
        camera2.SetActive(false);
        camera3.SetActive(false);
        camera4.SetActive(true);
        camera5.SetActive(false);
        camera6.SetActive(false);
    }

    private IEnumerator EnableStuffAfterDelay5()
    {
        yield return new WaitForSeconds(1f);
        camera1.SetActive(false);
        camera2.SetActive(false);
        camera3.SetActive(false);
        camera4.SetActive(false);
        camera5.SetActive(true);
        camera6.SetActive(false);
    }

    private IEnumerator EnableStuffAfterDelay6()
    {
        yield return new WaitForSeconds(1f);
        camera1.SetActive(false);
        camera2.SetActive(false);
        camera3.SetActive(false);
        camera4.SetActive(false);
        camera5.SetActive(false);
        camera6.SetActive(true);
    }

    private void Start()
    {
        ColorUtility.TryParseHtmlString("#E2E2E2", out lightGrey);
        ColorUtility.TryParseHtmlString("#A1CEF8", out blueButton);

        levelChanger = gameObject;
        anim = levelChanger.GetComponent<Animator>();

        timelineImage.gameObject.SetActive(isActive);
        level1.gameObject.SetActive(isActive);
        level2.gameObject.SetActive(isActive);
        level3.gameObject.SetActive(isActive);
        level4.gameObject.SetActive(isActive);
        level5.gameObject.SetActive(isActive);
        level6.gameObject.SetActive(isActive);

        clock.onClick.AddListener(ClockButton);
        level1.onClick.AddListener(Level1Button);
        level2.onClick.AddListener(Level2Button);
        level3.onClick.AddListener(Level3Button);
        level4.onClick.AddListener(Level4Button);
        level5.onClick.AddListener(Level5Button);
        level6.onClick.AddListener(Level6Button);
    }

    void Update()
    {
        if (camera1.activeSelf)
        {
            level1.GetComponent<Image>().color = blueButton;
            level2.GetComponent<Image>().color = lightGrey;
            level3.GetComponent<Image>().color = lightGrey;
            level4.GetComponent<Image>().color = lightGrey;
            level5.GetComponent<Image>().color = lightGrey;
            level6.GetComponent<Image>().color = lightGrey;
        }
        if (camera2.activeSelf)
        {
            level1.GetComponent<Image>().color = lightGrey;
            level2.GetComponent<Image>().color = blueButton;
            level3.GetComponent<Image>().color = lightGrey;
            level4.GetComponent<Image>().color = lightGrey;
            level5.GetComponent<Image>().color = lightGrey;
            level6.GetComponent<Image>().color = lightGrey;
        }
        if (camera3.activeSelf)
        {
            level1.GetComponent<Image>().color = lightGrey;
            level2.GetComponent<Image>().color = lightGrey;
            level3.GetComponent<Image>().color = blueButton;
            level4.GetComponent<Image>().color = lightGrey;
            level5.GetComponent<Image>().color = lightGrey;
            level6.GetComponent<Image>().color = lightGrey;
        }
        if (camera4.activeSelf)
        {
            level1.GetComponent<Image>().color = lightGrey;
            level2.GetComponent<Image>().color = lightGrey;
            level3.GetComponent<Image>().color = lightGrey;
            level4.GetComponent<Image>().color = blueButton;
            level5.GetComponent<Image>().color = lightGrey;
            level6.GetComponent<Image>().color = lightGrey;
        }
        if (camera5.activeSelf)
        {
            level1.GetComponent<Image>().color = lightGrey;
            level2.GetComponent<Image>().color = lightGrey;
            level3.GetComponent<Image>().color = lightGrey;
            level4.GetComponent<Image>().color = lightGrey;
            level5.GetComponent<Image>().color = blueButton;
            level6.GetComponent<Image>().color = lightGrey;
        }
        if (camera6.activeSelf)
        {
            level1.GetComponent<Image>().color = lightGrey;
            level2.GetComponent<Image>().color = lightGrey;
            level3.GetComponent<Image>().color = lightGrey;
            level4.GetComponent<Image>().color = lightGrey;
            level5.GetComponent<Image>().color = lightGrey;
            level6.GetComponent<Image>().color = blueButton;
        }
    }

    public void ClockButton()
    {
        isActive = !isActive;
        timelineImage.gameObject.SetActive(isActive);
        level1.gameObject.SetActive(isActive);
        level2.gameObject.SetActive(isActive);
        level3.gameObject.SetActive(isActive);
        level4.gameObject.SetActive(isActive);
        level5.gameObject.SetActive(isActive);
        level6.gameObject.SetActive(isActive);
    }

    public void Level1Button()
    {
        anim.SetTrigger("FadeOut");
        StartCoroutine(EnableStuffAfterDelay1());
    }

    public void Level2Button()
    {
        anim.SetTrigger("FadeOut");
        StartCoroutine(EnableStuffAfterDelay2());
    }

    public void Level3Button()
    {
        anim.SetTrigger("FadeOut");
        StartCoroutine(EnableStuffAfterDelay3());
    }

    public void Level4Button()
    {
        anim.SetTrigger("FadeOut");
        StartCoroutine(EnableStuffAfterDelay4());
    }

    public void Level5Button()
    {
        anim.SetTrigger("FadeOut");
        StartCoroutine(EnableStuffAfterDelay5());
    }

    public void Level6Button()
    {
        anim.SetTrigger("FadeOut");
        StartCoroutine(EnableStuffAfterDelay6());
    }
}
