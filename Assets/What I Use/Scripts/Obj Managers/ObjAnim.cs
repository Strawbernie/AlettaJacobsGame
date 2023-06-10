using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Activates animation of opening/closing for the object on tap/pinch
/// or Go Back button pressed
/// </summary>
public class ObjAnim : MonoBehaviour
{
    public DisabledMode disabledMode;

    public Button goBackButton;

    public Camera cameraInUse;
    Animator anim;
    public bool isOpen = false;

    // Boolean that will allow the code to detect touch
    public bool objectTapDetectorActive = true;

    void Start()
    {
        goBackButton.onClick.AddListener(BackButtonClicked);
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (!disabledMode.zoomDisabled)
        {
            if (objectTapDetectorActive)
            {
                #region Tap
                // Check for tap on mobile device
                if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
                {
                    Ray ray = cameraInUse.ScreenPointToRay(Input.GetTouch(0).position);
                    RaycastHit hit;

                    if (Physics.Raycast(ray, out hit))
                    {
                        if (hit.transform.gameObject == gameObject)
                        {
                            objectTapDetectorActive= false;

                            if (!isOpen)
                            {
                                anim.SetTrigger("TrZoomIn");
                                isOpen = true;
                            }
                        }
                    }
                }
                #endregion
            }
        }

        #region Pinch
        // If there are two touches on the device...
        if (Input.touchCount == 2)
        {
            // Store both touches.
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            // Find the position in the previous frame of each touch.
            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            // Find the magnitude of the vector (the distance) between the touches in each frame.
            float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

            // Find the difference in the distances between each frame.
            float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

            // Check the sign of the deltaMagnitudeDiff variable to determine pinch direction.
            if (deltaMagnitudeDiff > 0)
            {
                if (isOpen)
                {
                    // Pinch in (zoom out).
                    //Do animation on pinch
                    anim.SetTrigger("TrZoomOut");
                    isOpen = false;
                    objectTapDetectorActive = true;
                }
            }
            else if (deltaMagnitudeDiff < 0)
            {
                //Do nothing
            }
        }
        #endregion
    }

    public void BackButtonClicked()
    {
        if (isOpen)
        {
            anim.SetTrigger("TrZoomOut");
            isOpen = false;
            objectTapDetectorActive = true;
        }
    }
}


