using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
//This code works for every 2d UI animation
public class Tutorials : MonoBehaviour
{
    //This code requires you to have a canvas with an UI - Image object in it, you then drag this code onto the UI-Image object
    //This variable allows you to decide how long 1 frame of the animation should stay on the screen
    public float duration;

    [SerializeField] private Sprite[] sprites;

    private Image image;
    private int index = 0;
    private float timer = 0;
    public GameObject TapAnimation;
    void Start()
    {
        image = GetComponent<Image>();
    }
    private void Update()
    {
        if ((timer += Time.deltaTime) >= (duration / sprites.Length))
        {
            timer = 0;
            //the sprite index allows you to choose an amount of frames you want to set in Unity, after you've done this you can drag every frame of the animation in the sprite index in unity, and it will loop the animation.
            image.sprite = sprites[index];
            index = (index + 1) % sprites.Length;
        }
        // Check for touch input
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Check if the touch phase is just began, then destroy the tapanimation
            if (touch.phase == TouchPhase.Began)
            {
                TapAnimation.SetActive(false);
            }
        }
    }
}