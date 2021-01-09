using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.Audio;
using UnityEngine.UIElements;
using JetBrains.Annotations;
using UnityEngine.Advertisements;
using UnityEngine.Monetization;
using System.Threading;

public class Pause : MonoBehaviour
{
     

    public  GameObject PauseMenu;

    public GameObject PlayerMan;

    public GameObject ButtonAfter;

    public Score ScoreScript;

    public AdManager AdMan;

    public AudioSource JumpSound;

    public bool isGamePaused = false;

    public bool isGameContinuing = false;

    public float Amount;

    //float starTime = Time.time;

    [SerializeField]
    public float TravelAmount;

    

    // Update is called once per frame
    void Update()
    {

        Amount = ScoreScript.m_ScoreAmount;
        /*if (isGamePaused == false)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {

                JumpSound.Play();

            }

            if (Input.touchCount > 0)
            {

                Sound();
                

            }
        }   */
    }

    /*public void Sound()
    {
        if (JumpSound.isPlaying == false)
        {
            JumpSound.Play();
        }
    }*/

    

    public void PauseGame()
    {
        PauseMenu.SetActive(true);

        isGamePaused = true;

        Obstacles.m_MoveSpeed = 0f;
        Obstacles.m_SpeedAcceleration = 0f;
        backgroundArt.m_MoveSpeed = 0f;
        backgroundArt.m_SpeedAcceleration = 0f;
        

        Score.m_PointIncreasedPerSecond = 0f;


        
    }

    public void RestartGame()
    {
        isGamePaused = false;

        MasterController.GetInstance.CurrentScore = 0f;

        SceneManager.LoadScene(2);

        

        Obstacles.m_MoveSpeed = 6f;
        Obstacles.m_SpeedAcceleration = 0.0005f;
        backgroundArt.m_MoveSpeed = 3f;
        backgroundArt.m_SpeedAcceleration = 0.00005f;

        Score.m_PointIncreasedPerSecond = 5f;
        Score.m_PointIncreasedPerSecond += Score.m_PointAccerleration * Time.deltaTime;
    }


    public void MenuLoad()
    {
        MasterController.GetInstance.CurrentScore = 0f;
        SceneManager.LoadScene(1);

        isGamePaused = false;

        Obstacles.m_MoveSpeed = 6f;
        Obstacles.m_SpeedAcceleration = 0.0005f;
        backgroundArt.m_MoveSpeed = 3f;
        backgroundArt.m_SpeedAcceleration = 0.00005f;

        Score.m_PointIncreasedPerSecond = 5f;
        Score.m_PointIncreasedPerSecond += Score.m_PointAccerleration * Time.deltaTime;
    }

    

    public void ContinueGame()
    {
        AdMan.StartCoroutine("ShowAd");
        
        

        //isGameContinuing = false;

        TravelAmount = Amount;

        ButtonAfter.SetActive(true);


        PlayerMan.SetActive(false);

        isGamePaused = true;

        PauseMenu.SetActive(false);

        Obstacles.m_MoveSpeed = 0f;
        Obstacles.m_SpeedAcceleration = 0f;
        backgroundArt.m_MoveSpeed = 0f;
        backgroundArt.m_SpeedAcceleration = 0f;


        Score.m_PointIncreasedPerSecond = 0f;


    }

    public void ButtonAfterAd()
    {
        SceneManager.LoadScene(2);

        //PlayerMan.SetActive(True);

        Obstacles.m_MoveSpeed = 6f;
        Obstacles.m_SpeedAcceleration = 0.0005f;
        backgroundArt.m_MoveSpeed = 3f;
        backgroundArt.m_SpeedAcceleration = 0.00005f;

        Score.m_PointIncreasedPerSecond = 5f;
        Score.m_PointIncreasedPerSecond += Score.m_PointAccerleration * Time.deltaTime;


    }
}
