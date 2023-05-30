using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PaperLVL6 : MonoBehaviour
{
    public GameObject Paper;
    public GameObject Text;

    // Update is called once per frame

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == Paper)
            {
                StartCoroutine(EnableStuffAfterDelay());
            }
        }
       
        
    }
    private IEnumerator EnableStuffAfterDelay()
    {
        yield return new WaitForSeconds(2f);
        Text.SetActive(true);
    }
}
