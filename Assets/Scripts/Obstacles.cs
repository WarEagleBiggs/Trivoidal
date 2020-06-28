 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public static float m_MoveSpeed = 6f;

    public static float m_SpeedAcceleration = 0.005f;

    //private float m_StartTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
       // m_StartTime = Time.time;

        
    }

    // Update is called once per frame
    void Update()
    {
        //if ((Time.time - m_StartTime) > 10f) {

        //    m_MoveSpeed *= m_SpeedAcceleration;

        //    m_StartTime = Time.time;

        //    Debug.Log("Sped up " + m_MoveSpeed);
        //}

        transform.Translate(Vector2.left * Time.deltaTime * m_MoveSpeed);

        m_MoveSpeed += m_SpeedAcceleration * Time.deltaTime;

        Debug.Log(m_MoveSpeed);



    }
}
