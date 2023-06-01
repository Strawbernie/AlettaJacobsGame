using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobeSpin : MonoBehaviour
{

    private float rotationSpeed = 1.0f;
    private Vector2 swipeStartPosition;
    private bool isSwiping = false;
    public GameObject ParticleSystem;

    void Update()
    {
        if (Camera.main.transform.localEulerAngles.y > 131.5f && Camera.main.transform.localEulerAngles.y < 133.5f)
        {
            Destroy(ParticleSystem);
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                switch (touch.phase)
                {
                    case TouchPhase.Began:
                        swipeStartPosition = touch.position;
                        isSwiping = true;
                        break;

                    case TouchPhase.Moved:
                        if (isSwiping)
                        {
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
    }
}