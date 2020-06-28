using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS;
public class Player : MonoBehaviour
{

    [Range(1, 12)]
    public float m_JumpVelocity;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * m_JumpVelocity;
        }

        if (Input.touchCount > 0) {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * m_JumpVelocity;

        }

        



    }
}
