using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelChanger : MonoBehaviour
{
    public Animator anim;

    public void OnFadeComplete()
    {
        anim.SetTrigger("FadeIn");
    }
}