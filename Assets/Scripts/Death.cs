using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    //public int DeathCount;

    private MasterController m_Controller;

    public Pause m_Pause;

    private void Start()
    {
        m_Controller = MasterController.GetInstance;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        

        m_Controller.m_DeathCount += 1;
        

        m_Pause.PauseMenu.SetActive(true);

        m_Pause.isGamePaused = true;

        Obstacles.m_MoveSpeed = 0f;
        Obstacles.m_SpeedAcceleration = 0f;
        backgroundArt.m_MoveSpeed = 0f;
        backgroundArt.m_SpeedAcceleration = 0f;

        Score.m_PointIncreasedPerSecond = 0f;
    }


}
