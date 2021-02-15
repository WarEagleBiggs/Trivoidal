using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS;
using UnityEngine.Audio;
public class Player : MonoBehaviour
{

    [Range(1, 100)]
    public float m_JumpVelocity;
    private Rigidbody2D rigidBody;
    public Transform groundCheckPoint;
    public Transform redCheckPoint;
    public float groundCheckRadius = 0.4132358f;
    public LayerMask groundLayer;
    public LayerMask RedLayer;
    private bool isTouchingGround;
    private bool isRedNear;

    public AudioSource JumpSound;

    public Pause PauseScript;

    public SceneController S_Controller;

    public GameObject GameMusic;
    


    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();

        GameMusic.SetActive(MasterController.GetInstance.m_IsAudioEnabled);

    }
    public void Sound()
    {
        if (MasterController.GetInstance.m_IsAudioEnabled)
        {
            if (JumpSound.isPlaying == false)
            {
                JumpSound.Play();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, groundLayer);
       


        if (Input.GetKeyDown(KeyCode.Space)) {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * m_JumpVelocity;

            Sound();
        }

        if ( Input.touchCount > 0 && isTouchingGround) {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * m_JumpVelocity;

            Sound();

        }


        if (PauseScript.isGameContinuing == true)
        {
            
        }


        // serialize data every frame
        MasterController.GetInstance.Serialize();

    }
}
