using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testcollisionshit : MonoBehaviour
{
    private void OnCollisionEnter(Collision dataFromCollision)
    {//check if collision is with specific named thing
        if (dataFromCollision.gameObject.name == "PlaceForThatSpecificShit")
        {
            Debug.Log(true);
            //destroy the rigid body so you cant drag it anymore
            Destroy(GetComponent<Rigidbody>());
            //remove from the comments, add a specific coordinates
            //transform.position = new Vector3(X, Y, Z);
        }
    }
}
