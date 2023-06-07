using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobeSpin : MonoBehaviour
{

    private float rotationSpeed = 1.0f;
    private Vector2 swipeStartPosition;
    private bool isSwiping = false;
    public GameObject ParticleSystem;
    public DisabledMode disabledMode;
    public SwipeDetector SD;

    public void Update()
    {
        //checks if the camera is in the position where the puzzle will take place
        if (Camera.main.transform.localEulerAngles.y > 131.5f && Camera.main.transform.localEulerAngles.y < 133.5f)
        {

            Destroy(ParticleSystem);
            //if the player touches the screen
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                switch (touch.phase)
                {
                    //if the player started touching the screen, the start position of the swipe is decided, and the isswiping bool is set to true
                    case TouchPhase.Began:
                        swipeStartPosition = touch.position;
                        isSwiping = true;
                        break;

                    case TouchPhase.Moved:
                        if (isSwiping)
                        {
                            //calculates the speed of the rotation by checking big the swipe distance is.
                            float swipeDelta = (swipeStartPosition.x - touch.position.x) * rotationSpeed * Time.deltaTime;
                            transform.Rotate(Vector3.up, swipeDelta);
                        }
                        break;

                    case TouchPhase.Ended:
                        isSwiping = false;
                        break;
                }
            }
        }
        else
        {
            SD.GlobeZoom = false;
        }
    }
}