using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    public Image m_WhiteFade;

    // Start is called before the first frame update
    void Start()
    {
        m_WhiteFade.canvasRenderer.SetAlpha(1f);

        fadeIn();

        m_WhiteFade.enabled = true;
    }
  

        void fadeIn ()
    {
        m_WhiteFade.CrossFadeAlpha(0, 2, false);
    }
}
