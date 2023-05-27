using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorials : MonoBehaviour
{

    public Image m_Image;

    public Sprite[] m_SpriteArray;
    public float m_Speed = .02f;

    private int m_IndexSprite;
    Coroutine m_CorotineAnim;
    bool IsDone;
    public GameObject cameraScene;
    public GameObject TapAnimation;
    public bool inLevel;
    public void Update()
    {
        if (TapAnimation.activeSelf)
        {
            IsDone = false;
            StartCoroutine(Func_PlayAnimUI());
        }
        // Check for touch input
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Check if the touch phase is just began
            if (touch.phase == TouchPhase.Began)
            {
                Destroy(TapAnimation);
            }
        }
}
    IEnumerator Func_PlayAnimUI()
    {
        yield return new WaitForSeconds(m_Speed);
        if (m_IndexSprite >= m_SpriteArray.Length)
        {
            yield return new WaitForSeconds(.2f);
            m_IndexSprite = 0;
        }
        m_Image.sprite = m_SpriteArray[m_IndexSprite];
        m_IndexSprite += 1;
        if (IsDone == false)
            m_CorotineAnim = StartCoroutine(Func_PlayAnimUI());
    }
}