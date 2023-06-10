using PixelCrushers.DialogueSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The code checks if the player is playing level 1 for the first time,
/// if they do - after they tap the child they get sent to the next level
/// </summary>

public class BabyTapped : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;

    public ObjAnimBaby babyBedAnim;

    Animator anim;
    public GameObject babyBed;

    Animator animator;
    public GameObject levelChanger;

    public DisabledMode disabledMode;
    public FirstTimePassed firstTimePassed;
    public GameObject ParticleSystem;
    public GameObject HintPanel;

    [SerializeField] DialogueChecker dialogueChecker; // Add a reference to the correct dialogue checker.
    private IEnumerator EnableStuffAfterDelay()
    {
        yield return new WaitForSeconds(1f);
        disabledMode.goBackDisabled = true;
        disabledMode.swipeDisabled = false;
        camera1.SetActive(false);
        camera2.SetActive(true);
        Destroy(ParticleSystem);
        DialogueManager.StartConversation("Level2 DialogueStart"); // Change this to the correct one for level 2el 2
    }

    private void Start()
    {
        anim = babyBed.GetComponent<Animator>();
        animator = levelChanger.GetComponent<Animator>();
    }
    void Update()
    {
        if (babyBedAnim.isOpen && firstTimePassed.firstTimeLevel1)
        {
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
                {
                    firstTimePassed.firstTimeLevel1 = false;
                    anim.SetTrigger("TrZoomOut");
                    babyBedAnim.isOpen = false;
                    animator.SetTrigger("FadeOut");
                    HintPanel.SetActive(false);
                    DialogueManager.StopConversation();
                    StartCoroutine(EnableStuffAfterDelay());

                    DialogueManager.StopConversation();
                    firstTimePassed.firstTimeLevel1 = false;

                }
            }
        }
    }
}
