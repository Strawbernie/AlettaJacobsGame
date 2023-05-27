using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestPuzzle : MonoBehaviour
{
    public GameObject camera3;
    public GameObject camera4;

    public ObjAnim chestObjAnim;

    Animator anim;
    public GameObject chest;

    Animator animator;
    public GameObject levelChanger;

    public DisabledMode disabledMode;
    public FirstTimePassed firstTimePassed;
    public GameObject ParticleSystem;

    private IEnumerator EnableStuffAfterDelay()
    {
        yield return new WaitForSeconds(3);
        anim.SetTrigger("TrZoomOut");
        chestObjAnim.isOpen = false;
        animator.SetTrigger("FadeOut");
        yield return new WaitForSeconds(1);
        disabledMode.goBackDisabled = true;
        disabledMode.swipeDisabled = false;
        camera3.SetActive(false);
        camera4.SetActive(true);
        Destroy(ParticleSystem);
    }

    // Start is called before the first frame update
    void Start()
    {
        anim = chest.GetComponent<Animator>();
        animator = levelChanger.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (chestObjAnim.isOpen && firstTimePassed.firstTimeLevel3)
        {
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
                {
                    firstTimePassed.firstTimeLevel3 = false;
                    StartCoroutine(EnableStuffAfterDelay());
                }
            }
        }
    }
}
