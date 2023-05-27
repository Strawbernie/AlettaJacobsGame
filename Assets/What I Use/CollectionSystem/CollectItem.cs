using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    // put this on the collectible
    private void OnMouseDown()
    {
        GlobalAchievements.achCount += 1;
        Destroy(gameObject);
    }
}
