using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoomALT : MonoBehaviour
{

    // Disabled Mode
    public DisabledMode disabledMode;

    // Go Back button
    public Button goBack;

    // Original camera specifics
    private Vector3 originalPosition;
    private Quaternion originalRotation;
    private float originalOrthoSize;

    // Last camera specifics
    private Vector3 lastPosition;
    private Quaternion lastRotation;
    private float lastOrthoSize;
    private bool isAtOriginalPosition = true;

    // Target object
    public GameObject objectToZoomInOn;

    // New camera specifics
    public Vector3 newPosition;
    public Quaternion newRotation;
    public float newOrthoSize;
    public float moveSpeed = 5f;

    // Boolean to check if the camera zooming in/out
    public bool isChanging = false;

    // Boolean that will allow the code to detect touch
    public bool objectTapDetectorActive = true;


    private void Start()
    {
        // Assign code to a button
        goBack.onClick.AddListener(BackButtonClicked); //It will zoom out on the button clicked

        // Get current camera related staff
        originalPosition = transform.position;
        originalRotation = transform.rotation;
        originalOrthoSize = Camera.main.orthographicSize;

        lastPosition = originalPosition;
        lastRotation = originalRotation;
        lastOrthoSize = originalOrthoSize;
    }
    
    void Update()
    {
        if (gameObject.activeSelf)
        {
            // Check for the zoom in to be enabled
            if (!disabledMode.zoomDisabled)
            {
                if (objectTapDetectorActive)
                {
                    #region Tap
                    // Check if the object is tapped
                    if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
                    {
                        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                        RaycastHit hit;

                        if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == objectToZoomInOn)
                        {
                            // Disable the Swipe Detector and enable the Go Back button
                            disabledMode.swipeDisabled = true;
                            disabledMode.goBackDisabled = false;

                            // disable tap detector while zoomed in
                            objectTapDetectorActive = false;

                            if (!isChanging)
                            {
                                // Zoom in
                                StartCoroutine(SmoothCameraChange(newPosition, newRotation, newOrthoSize));
                                isAtOriginalPosition = false;
                                
                            }
                        }
                    }
                    #endregion
                }

                #region Pinch
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
                        // Pinch in (zoom out).
                        if (!isChanging)
                        {
                            // Zoom out to the original position and rotation of the camera
                            StartCoroutine(SmoothCameraChange(lastPosition, lastRotation, lastOrthoSize));
                        }

                        // Enable Swipe Detector and disable Go Back button
                        StartCoroutine(DelayForEnableSwipeDetector());
                    }
                }
                #endregion
            }
        }
    }

    private IEnumerator DelayForEnableSwipeDetector()
    {
        disabledMode.zoomDisabled = true;
        yield return new WaitForSeconds(0.5f);
        disabledMode.zoomDisabled = false;
        disabledMode.goBackDisabled = true;
        disabledMode.swipeDisabled = false;
        objectTapDetectorActive = true;
    }

    private IEnumerator SmoothCameraChange(Vector3 targetPosition, Quaternion targetRotation, float targetOrthoSize)
    {
        Vector3 currentPos = transform.position;
        Quaternion currentRot = transform.rotation;
        float currentSize = Camera.main.orthographicSize;

        float t = 0;
        while (t < 1)
        {
            isChanging = true;
            t += Time.deltaTime * moveSpeed;
            transform.position = Vector3.Lerp(currentPos, targetPosition, t);
            transform.rotation = Quaternion.Lerp(currentRot, targetRotation, t);
            Camera.main.orthographicSize = Mathf.Lerp(currentSize, targetOrthoSize, t);
            yield return null;
            isChanging = false;
        }

        transform.position = targetPosition;
        transform.rotation = targetRotation;
        Camera.main.orthographicSize = targetOrthoSize;

        if (!isAtOriginalPosition)
        {
            lastPosition = currentPos;
            lastRotation = currentRot;
            lastOrthoSize = currentSize;
            isAtOriginalPosition = true;
        }
    }
    public void BackButtonClicked()
    {
        if (gameObject.activeSelf)
        {
            // Pinch in (zoom out).
            if (!isChanging)
            {
                // Zoom out to the original position and rotation of the camera
                StartCoroutine(SmoothCameraChange(lastPosition, lastRotation, lastOrthoSize));
            }

            // Enable Swipe Detector and disable Go Back button
            StartCoroutine(DelayForEnableSwipeDetector());
        }
    }
}
