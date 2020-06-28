using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{

    public TMP_Text m_ScoreText;
    public float m_ScoreAmount;
    public static float m_PointIncreasedPerSecond;
    public static float m_PointAccerleration = 0.05f;

    public TMP_Text m_CointCounter;

    
    void Start()
    {
        m_ScoreAmount = 0f;
        m_PointIncreasedPerSecond = 5f;
    }

    void Update()
    {
        m_ScoreText.text = (int)m_ScoreAmount + "";
        m_ScoreAmount += m_PointIncreasedPerSecond * Time.deltaTime;

        if ((int)m_ScoreAmount > MasterController.GetInstance.m_TopScore) {
            MasterController.GetInstance.m_TopScore = (int) m_ScoreAmount;
        }

        m_PointIncreasedPerSecond += m_PointAccerleration * Time.deltaTime;

    }

   

}
