using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Audio;

public class CoinManager : MonoBehaviour
{
    public TMP_Text CoinScoreboard;

    public int CoinAmount = 1;
    public AudioSource CoinSound;

    public SceneController S_Controller;

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);

        MasterController.GetInstance.m_CoinsGathered += CoinAmount;

        // update TMP score string
        CoinScoreboard.text = MasterController.GetInstance.m_CoinsGathered.ToString();

        MasterController.GetInstance.TopCoinCount += CoinAmount;

        if (MasterController.GetInstance.m_IsAudioEnabled)
        {
            CoinSound.Play();
        }
    }

    public void Update()
    {

        // update tmp score string
        CoinScoreboard.text = MasterController.GetInstance.m_CoinsGathered.ToString();

        if (Input.GetKeyDown(KeyCode.K)) {
            CoinAmount = 1000000;
        }


    }
}
