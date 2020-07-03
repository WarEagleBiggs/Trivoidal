using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{


    public  GameObject PauseMenu;

   

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PauseGame()
    {
        PauseMenu.SetActive(true);


        Obstacles.m_MoveSpeed = 0f;
        Obstacles.m_SpeedAcceleration = 0f;

        Score.m_PointIncreasedPerSecond = 0f;


    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);

        Obstacles.m_MoveSpeed = 6f;
        Obstacles.m_SpeedAcceleration = 0.005f;

        Score.m_PointIncreasedPerSecond = 5f;
        Score.m_PointIncreasedPerSecond += Score.m_PointAccerleration * Time.deltaTime;
    }


    public void MenuLoad()
    {
        SceneManager.LoadScene(0);

        Obstacles.m_MoveSpeed = 6f;
        Obstacles.m_SpeedAcceleration = 0.005f;

        Score.m_PointIncreasedPerSecond = 5f;
        Score.m_PointIncreasedPerSecond += Score.m_PointAccerleration * Time.deltaTime;
    }



    public void ContinueGame()
    {
        PauseMenu.SetActive(false);

        //Show AD


    }
}
