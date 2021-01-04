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

    public Pause PauseScript;

    public MasterController Mcontrol;

    
    void Start()
    {
        m_ScoreAmount = MasterController.GetInstance.m_CurrentScore;
        m_PointIncreasedPerSecond = 5f;
        
        
    }

    void Update()
    {
        if (PauseScript.isGamePaused == false)
        {
            m_ScoreText.text = (int)m_ScoreAmount + "";
            //m_ScoreAmount += m_PointIncreasedPerSecond * Time.deltaTime;
            MasterController.GetInstance.m_CurrentScore += m_PointIncreasedPerSecond * Time.deltaTime;
            m_ScoreAmount = MasterController.GetInstance.m_CurrentScore;

            if ((int)m_ScoreAmount > MasterController.GetInstance.m_TopScore)
            {
                MasterController.GetInstance.m_TopScore = (int)m_ScoreAmount;
            }
        }

        m_PointIncreasedPerSecond += m_PointAccerleration * Time.deltaTime;

        if (PauseScript.isGameContinuing == true)
        {
            Debug.Log(PauseScript.TravelAmount);
            m_ScoreAmount = m_ScoreAmount + PauseScript.TravelAmount;

        }

        //for testing
        if (Input.GetKeyDown(KeyCode.Y)){
            Debug.Log(m_ScoreAmount);
        }
    }



    
   

}
