using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeDetector : MonoBehaviour
{
    private Vector3 fp;   //First touch position
    private Vector3 lp;   //Last touch position
    private float dragDistance;  //minimum distance for a swipe to be registered

    public float rotationSpeed = 90f; // Adjust the rotation speed as desired
    public GameObject SwipeTutorial;
    public GameObject MainMenu;
    public GameObject pauseMenu;
    public GameObject Confirmmenu;
    public GameObject camera4;
    public bool isRotating = false;
    private Quaternion targetRotation;

    // Disabled mode
    public DisabledMode disabledMode;

    // Start is called before the first frame update
    void Start()
    {
        dragDistance = Screen.height * 15 / 100; //dragDistance is 15% height of the screen
    }

    // Update is called once per frame
    void Update()
    {
        if(!camera4.activeSelf && !MainMenu.activeSelf && !pauseMenu.activeSelf && !Confirmmenu.activeSelf)
        {
            if (!disabledMode.swipeDisabled)
            {
                if (!isRotating)
                {
                    if (Input.touchCount == 1) // user is touching the screen with a single touch
                    {
                        Destroy(SwipeTutorial);
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
                                        StartCameraRotation(90f);
                                    }
                                    else
                                    {   //Left swipe
                                        StartCameraRotation(-90f);
                                    }
                                }
                            }
                        }
                    }
                }
                if (isRotating)
                {
                    PerformCameraRotation();
                }
            }
        }
    }
    void StartCameraRotation(float angle)
    {
        Camera mainCamera = Camera.main;

        if (mainCamera != null)
        {
            Quaternion currentRotation = mainCamera.transform.rotation;
            Quaternion desiredRotation = Quaternion.Euler(30f, currentRotation.eulerAngles.y + angle, 0f);
            targetRotation = desiredRotation;
            isRotating = true;
            disabledMode.zoomDisabled = true; // disable zoom in/out script when rotating the room
        }
        else
        {
            Debug.LogWarning("Main camera not found.");
        }
    }

    void PerformCameraRotation()
    {
        Camera mainCamera = Camera.main;

        if (mainCamera != null)
        {
            mainCamera.transform.rotation = Quaternion.RotateTowards(mainCamera.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            if (Quaternion.Angle(mainCamera.transform.rotation, targetRotation) < 0.1f)
            {
                mainCamera.transform.rotation = targetRotation;
                isRotating = false;
                disabledMode.zoomDisabled = false; // enable zoom in/out script when rotating is finished
            }
        }
    }
}
