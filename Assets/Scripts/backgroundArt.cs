using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundArt : MonoBehaviour
{
    public static float m_MoveSpeed = 3f;

    public static float m_SpeedAcceleration = 0.00005f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector2.left * Time.deltaTime * m_MoveSpeed);

        m_MoveSpeed += m_SpeedAcceleration * Time.deltaTime;

        //Debug.Log(m_MoveSpeed);


        if (Input.GetKeyDown(KeyCode.F))
        {
            m_SpeedAcceleration = m_SpeedAcceleration * 1.5f;
        }


    }
}
