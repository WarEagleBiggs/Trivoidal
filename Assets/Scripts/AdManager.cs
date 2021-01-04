using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour
{
    private MasterController m_Controller;

    // Start is called before the first frame update
    private void Start()
    {
        m_Controller = MasterController.GetInstance;
    }

    // Update is called once per frame
    void Update()
    {
        if (m_Controller.m_DeathCount == 5)
        {
            StartCoroutine("ShowSkipAd");
            m_Controller.m_DeathCount = 0;
        }
    }
    IEnumerator ShowSkipAd()
    {
        Advertisement.Initialize("3862180", true);

        while (!Advertisement.IsReady())
            yield return null;

        Advertisement.Show("video");
    }

    IEnumerator ShowAd()
    {
        Advertisement.Initialize("3862180", true);

        while (!Advertisement.IsReady())
            yield return null;

        Advertisement.Show("rewardedVideo");
    }

}
