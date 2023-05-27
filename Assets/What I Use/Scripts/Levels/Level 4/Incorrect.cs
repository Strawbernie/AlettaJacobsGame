using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Incorrect : MonoBehaviour
{
    public GameObject setTrue;
    public GameObject setFalse;
    public GameObject setFalse1;
    public GameObject setFalse2;
    public GameObject Button;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
 
        {
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit hit;
                
                if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == Button)
                {
                    Debug.Log("Incorrect");
                    setTrue.SetActive(true);
                    setFalse.SetActive(false);
                    setFalse1.SetActive(false);
                    setFalse2.SetActive(false);
                }
            }
        }
    }
}
