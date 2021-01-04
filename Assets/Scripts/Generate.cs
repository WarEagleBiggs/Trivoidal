using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Generate : MonoBehaviour
{
    public GameObject RedObs;
    public Transform RedPos;
    public GameObject Coin;
    public Transform CoinPos;
    public Transform CoinOrangePos;
    public GameObject CoinOrange;
    public GameObject GreenCoin;
    public Transform GreenPos;
    public GameObject BackGround;
    public Transform BackPos;

    private float m_StartTime = 0;

    private List<GameObject> m_ObsList;

    private float WaitTime = 3f;

    private Bounds m_ObsBounds;

    private float m_MaxGap = 5f;
    private int m_MaxObsInScene = 20;

    // Start is called before the first frame update
    void Start()
    {
        RedPos = GetComponent<Transform>();
        CoinPos = GetComponent<Transform>();

        //StartCoroutine("Spawn");
        StartCoroutine("SpawnCoin");
        StartCoroutine("SpawnBack");
        //StartCoroutine("SpawnOrangeCoin");

        
        m_StartTime = Time.time;

        m_ObsList = new List<GameObject>();
        m_ObsBounds = FindExtents(RedObs);

        //Debug.Log("obj bounds " + m_ObsBounds);
        
    }

    public Bounds FindExtents(GameObject go)
    {
        Bounds ret = new Bounds();
        ret.max = new Vector3(Mathf.NegativeInfinity, Mathf.NegativeInfinity, Mathf.NegativeInfinity);
        ret.min = new Vector3(Mathf.Infinity, Mathf.Infinity, Mathf.Infinity);

        Component[] compList = go.GetComponentsInChildren(typeof(Renderer), true);

        foreach (Renderer rend in compList)
        {
            ret.Encapsulate(rend.bounds);
        }

        return ret;
    }


    public float OnlyCallOnce;
    public float OnlyCallOnce2;

    private void Update()
    {
        if ((Time.time - m_StartTime) >= WaitTime)
        {
            SpawnObstacle();
            m_StartTime = Time.time;
            //Debug.Log("Spawn");
        }
         if (ScoreMan.m_ScoreAmount >= Test && OnlyCallOnce == 0f)
        {

            OnlyCallOnce++;

            StartCoroutine("SpawnOrange");
           
        }
        if (ScoreMan.m_ScoreAmount >= Test2 && OnlyCallOnce2 == 0f)
        {

            OnlyCallOnce2++;

            StartCoroutine("SpawnGreen");

        }


    }

    IEnumerator SpawnOrange()
    {
        while (true)
        {
            //Debug.Log("HEY IT WORKS");
            Vector3 position = new Vector3(Random.Range(20f, 60.0f), Random.Range(-1f, 5f), 0f);
            Instantiate(CoinOrange, position, Quaternion.identity);
            transform.position = new Vector3(15, 0, 0);
            yield return new WaitForSeconds(2);
        }
    }
    IEnumerator SpawnGreen()
    {
        while (true)
        {
            //Debug.Log("HEY IT WORKS");
            Vector3 position = new Vector3(Random.Range(20f, 60.0f), Random.Range(-1f, 5f), 0f);
            Instantiate(GreenCoin, position, Quaternion.identity);
            transform.position = new Vector3(15, 0, 0);
            yield return new WaitForSeconds(2);
        }
    }



    void SpawnObstacle()
    {
        // StopCoroutine("Spawn");

        Vector3 position;

        while (true) {
            position = new Vector3(Random.Range(10f, 90f), -2.34f, 0f);
            // confirm that position is not too close to other obs
            bool isTooClose = false;

            float obsWidth = m_ObsBounds.extents.x;

            for (int i = 0; i < m_ObsList.Count; ++i) {
                GameObject obj = m_ObsList[i];
                if (Mathf.Abs(position.x - obj.transform.position.x) < ((obsWidth * 2f) + m_MaxGap)) {
                    isTooClose = true;
                   break;
                }
            }
            if (!isTooClose) {
                break;
            }
        }

        GameObject newGo = Instantiate(RedObs, position, Quaternion.identity);
        m_ObsList.Add(newGo);

        while (m_ObsList.Count > m_MaxObsInScene) {
            // remove gameobject from scene
            GameObject.Destroy(m_ObsList[0]);
            // remove entry
            m_ObsList.Remove(m_ObsList[0]);
            
        }



        //StartCoroutine("Spawn");
    }
    /* IEnumerator Spawn()
     {
             yield return new WaitForSeconds(WaitTime);
             SpawnObstacle();



     }*/
    public Score ScoreMan;

    public float Test = 500f;
    public float Test2 = 1000f;
    

    
    IEnumerator SpawnCoin()
    {
        while (true)
        {
            Vector3 position = new Vector3(Random.Range(20f, 60.0f), Random.Range(-1f, 5f), 0f);
            Instantiate(Coin, position, Quaternion.identity);
            transform.position = new Vector3(15, 0, 0);
            yield return new WaitForSeconds(2);

        }
    }

 
    private GameObject m_LastClone;

    IEnumerator SpawnBack()
    {
        while (true)
        {
            Vector3 position = new Vector3(38,0,0);
            if (m_LastClone == null)
            {
                m_LastClone = BackGround;
            }
            m_LastClone = Instantiate(m_LastClone, position, Quaternion.identity);
            
            Vector3 scale = m_LastClone.transform.localScale;
            m_LastClone.transform.localScale = new Vector3(-1 * scale.x, scale.y, scale.z);
            yield return new WaitForSeconds(11);

        }
    }

}
