using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobeWin : MonoBehaviour
{
    public GameObject WinCheck;
    public GameObject camera6;
    public GameObject camera7;
    public GameObject Hint;
    Animator animator;
    public DisabledMode disabledMode;
    //public GameObject globeCamera;
    public bool objectTapDetectorActive = true;
    public GameObject HintPanel;
    public GameObject levelChanger;
    // Update is called once per frame
    private void Start()
    {
        animator = levelChanger.GetComponent<Animator>();
    }
    void Update()
    {
        if (WinCheck.activeSelf)
        {
            animator.SetTrigger("FadeOut");
            HintPanel.SetActive(false);
            WinCheck.SetActive(false);
            StartCoroutine(EnableStuffAfterDelay());
        }
    }
    private IEnumerator EnableStuffAfterDelay()
    {
        yield return new WaitForSeconds(1f);
        disabledMode.goBackDisabled = true;
        disabledMode.swipeDisabled = false;
        camera6.SetActive(false);
        camera7.SetActive(true);
        HintPanel.SetActive(false);
        Hint.SetActive(false);
    }
}
