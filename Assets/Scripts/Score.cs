using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{

    public TMP_Text m_ScoreText;
    public float m_ScoreAmount;
    public float m_PointIncreasedPerSecond;
    
    void Start()
    {
        m_ScoreAmount = 0f;
        m_PointIncreasedPerSecond = 5f;
    }

    void Update()
    {
        m_ScoreText.text = (int)m_ScoreAmount + "";
        m_ScoreAmount += m_PointIncreasedPerSecond * Time.deltaTime;
    }

   

}
