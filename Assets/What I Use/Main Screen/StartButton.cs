using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public Button button;
    public GameObject sceneChanger;
    public GameObject Menu;
    Animator anim;
    public GameObject TapAnimation;

    private void Start()
    {
        button.onClick.AddListener(GoToGame);
        anim = sceneChanger.GetComponent<Animator>();
    }

    public void GoToGame()
    {
        anim.SetTrigger("FadeOut");
    }

    public void onEndComplete()
    {
        StartCoroutine(EnableStuffAfterDelay());
    }
    private IEnumerator EnableStuffAfterDelay()
    {
        yield return new WaitForSeconds(1f);
        Menu.SetActive(false);
        TapAnimation.SetActive(true);
    }
}
