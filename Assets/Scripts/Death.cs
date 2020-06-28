using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{

    public Pause m_Pause;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        m_Pause.PauseMenu.SetActive(true);

        Obstacles.m_MoveSpeed = 0f;
        Obstacles.m_SpeedAcceleration = 0f;

        Score.m_PointIncreasedPerSecond = 0f;
    }



    private void Update()
    {
        
    }
}
