using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The code activated drag and drop for the books when the suitcase is open
/// </summary>

public class DragAndDrop : MonoBehaviour
{
    public ObjAnim suitcaseAnim;

    private Vector3 positionCamera = new Vector3(28, 1.5f, 0.7f);
    private Quaternion rotationCamera = Quaternion.Euler(45, 0, 0);

    public float forceAmount = 500;

    Rigidbody selectedRigidbody;
    Camera targetCamera;
    Vector3 originalScreenTargetPosition;
    Vector3 originalRigidbodyPos;
    float selectionDistance;
    public GameObject Tutorial;
    public GameObject ParticleSystem;

    // Start is called before the first frame update
    void Start()
    {
        targetCamera = Camera.main;
    }

    void Update()
    {
        if (transform.position == positionCamera && transform.rotation == rotationCamera)
        {
            if (suitcaseAnim.isOpen)
            {
                Destroy(ParticleSystem);
                if (Input.touchCount > 0)
                {
                    Touch touch = Input.GetTouch(0);

                    if (touch.phase == TouchPhase.Began)
                    {
                        //Check if we are hovering over Rigidbody, if so, select it
                        selectedRigidbody = GetRigidbodyFromTouch(touch.position);
                        Tutorial.SetActive(false);
                    }
                    else if (touch.phase == TouchPhase.Ended && selectedRigidbody)
                    {
                        //Release selected Rigidbody if there any
                        selectedRigidbody = null;
                    }
                }
            }
        }
        }

    void FixedUpdate()
    {
        if (selectedRigidbody)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 mousePositionOffset = targetCamera.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, selectionDistance)) - originalScreenTargetPosition;
            selectedRigidbody.velocity = (originalRigidbodyPos + mousePositionOffset - selectedRigidbody.transform.position) * forceAmount * Time.deltaTime;
        }
    }

    Rigidbody GetRigidbodyFromTouch(Vector2 touchPosition)
    {
        RaycastHit hitInfo = new RaycastHit();
        Ray ray = targetCamera.ScreenPointToRay(touchPosition);
        bool hit = Physics.Raycast(ray, out hitInfo);
        if (hit)
        {
            if (hitInfo.collider.gameObject.GetComponent<Rigidbody>())
            {
                selectionDistance = Vector3.Distance(ray.origin, hitInfo.point);
                originalScreenTargetPosition = targetCamera.ScreenToWorldPoint(new Vector3(touchPosition.x, touchPosition.y, selectionDistance));
                originalRigidbodyPos = hitInfo.collider.transform.position;
                return hitInfo.collider.gameObject.GetComponent<Rigidbody>();
            }
        }

        return null;
    }
}
