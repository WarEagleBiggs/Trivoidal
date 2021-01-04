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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);

        int score = int.Parse(CoinScoreboard.text);

        score += CoinAmount;

        CoinScoreboard.text = score.ToString();

        MasterController.GetInstance.m_TopCoinCount += CoinAmount;

        CoinSound.Play();
    }

    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.K)) {
            CoinAmount = 1000000;
        }


    }
}
