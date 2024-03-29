﻿using System.Collections;
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

    public GameObject Music2;

    public TMP_Text m_CointCounter;

    public Pause PauseScript;

    public MasterController Mcontrol;

    public SceneController S_Controller;

    public CoinManager Cmanage;

    
    void Start()
    {
        m_ScoreAmount = MasterController.GetInstance.CurrentScore;
        m_PointIncreasedPerSecond = 5f;
        
    }

    public int m_CurrentCoinCount;

    void Update()
    {
        if (PauseScript.isGamePaused == false)
        {
            m_ScoreText.text = (int)m_ScoreAmount + "";
            //m_ScoreAmount += m_PointIncreasedPerSecond * Time.deltaTime;
            MasterController.GetInstance.CurrentScore += m_PointIncreasedPerSecond * Time.deltaTime;
            m_ScoreAmount = MasterController.GetInstance.CurrentScore;

            if ((int)m_ScoreAmount > MasterController.GetInstance.TopScore)
            {
                MasterController.GetInstance.TopScore = (int)m_ScoreAmount;
            }
        }

        m_PointIncreasedPerSecond += m_PointAccerleration * Time.deltaTime;

        if (PauseScript.isGameContinuing == true)
        {
            Debug.Log(PauseScript.TravelAmount);
            m_ScoreAmount = m_ScoreAmount + PauseScript.TravelAmount;

            m_CurrentCoinCount = MasterController.GetInstance.TopCoinCount;
            int Score = int.Parse(Cmanage.CoinScoreboard.text);
            Score = m_CurrentCoinCount;


        }

        //for testing
        if (Input.GetKeyDown(KeyCode.Y)){
            Debug.Log(m_ScoreAmount);
        }

/*
        if(S_Controller.isAudioON == false)
        {
            Music2.SetActive(!Music2.activeSelf);
        }*/

    }



    
   

}
