using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class LockControl : MonoBehaviour
{
    public GameObject oldSafe;
    public GameObject newSafe;

    private Vector3 initialPosition;
    private Quaternion initialRotation;

    Animator anim;

    private int[] result, correctCombination;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = oldSafe.transform.position;
        initialRotation = oldSafe.transform.rotation;

        anim = newSafe.GetComponent<Animator>();

        result = new int[] { 0, 0, 0 };
        correctCombination = new int[] { 3, 7, 9 };
        ROtate.Rotated += CheckResults;
    }

    private void CheckResults(string wheelName, int number)
    {
        switch (wheelName)
        {
            case "wheel1":
                result[0] = number;
                break;

            case "wheel2":
                result[1] = number;
                break;

            case "wheel3":
                result[2] = number;
                break;
        }

        if (result[0] == correctCombination[0] && result[1] == correctCombination[1] && result[2] == correctCombination[2])
        {
            Destroy(oldSafe);
            GameObject newObject = Instantiate(newSafe, initialPosition, initialRotation);
            if (newObject != null)
            {
                anim.SetTrigger("TrOpen");
            }
        }
    }

    private void OnDestroy()
    {
        ROtate.Rotated -= CheckResults;
    }
}

