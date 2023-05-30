using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeDetector : MonoBehaviour
{
    private Vector3 fp;   //First touch position
    private Vector3 lp;   //Last touch position
    private float dragDistance;  //minimum distance for a swipe to be registered
    public GameObject camera4;
    // Boolean to check if the camera is in rotation
    private bool isRotating = false;

    // Disabled mode
    public DisabledMode disabledMode;
    public GameObject SwipeTutorial;
    public GameObject MainMenu;
    public GameObject pauseMenu;
    public GameObject Confirmmenu;

    IEnumerator RotateMe(Vector3 byAngles, float inTime)
    {
        var fromAngle = Camera.main.transform.rotation;
        var toAngle = Quaternion.Euler(Camera.main.transform.eulerAngles + byAngles);
        for (var t = 0f; t <= 1.0f; t += Time.deltaTime / inTime)
        {
            isRotating = true; //starts rotation
            disabledMode.zoomDisabled = true; // disable zoom in/out script when rotating the room
            Camera.main.transform.rotation = Quaternion.Slerp(fromAngle, toAngle, t);
            yield return null;
            isRotating = false; //ends rotation
            disabledMode.zoomDisabled = false; // enable zoom in/out script when rotating is finished
            Destroy(SwipeTutorial);
        }
    }

    void Start()
    {
        dragDistance = Screen.height * 15 / 100; //dragDistance is 15% height of the screen
    }

    void Update()
    {
        if (!camera4.activeSelf && !MainMenu.activeSelf && !pauseMenu.activeSelf && !Confirmmenu.activeSelf)
        {
            if (!disabledMode.swipeDisabled)
            {
                if (Input.touchCount == 1) // user is touching the screen with a single touch
                {
                    Touch touch = Input.GetTouch(0); // get the touch
                    if (touch.phase == TouchPhase.Began) //check for the first touch
                    {
                        fp = touch.position;
                        lp = touch.position;
                    }
                    else if (touch.phase == TouchPhase.Moved) // update the last position based on where they moved
                    {
                        lp = touch.position;
                    }
                    else if (touch.phase == TouchPhase.Ended) //check if the finger is removed from the screen
                    {
                        lp = touch.position;  //last touch position. Ommitted if you use list

                        //Check if drag distance is greater than 20% of the screen height
                        if (Mathf.Abs(lp.x - fp.x) > dragDistance || Mathf.Abs(lp.y - fp.y) > dragDistance)
                        {//It's a drag
                         //check if the drag is vertical or horizontal
                            if (Mathf.Abs(lp.x - fp.x) > Mathf.Abs(lp.y - fp.y))
                            {   //If the horizontal movement is greater than the vertical movement...
                                if ((lp.x > fp.x))  //If the movement was to the right)
                                {   //Right swipe
                                    if (isRotating == false) //checks if it's rotating
                                    {
                                        StartCoroutine(RotateMe(Vector3.up * 90.0f, 0.5f));
                                    }
                                }
                                else
                                {   //Left swipe
                                    if (isRotating == false) //checks if it's rotating
                                    {
                                        StartCoroutine(RotateMe(Vector3.up * -90.0f, 0.5f));
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}