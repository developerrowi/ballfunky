﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class BallMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;

    public bool started = false;

    private bool isDown = false;

    private bool isGoingUp = false;
    public float forwardForce = 1000f; 

    public float upwardForce = 20100f; 
    
    public float customGravity = 1000f;
    public float downwardForce = 30000f;

    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    //    rb.AddForce(0,0, forwardForce * Time.deltaTime);
        rb.AddForce(0, -customGravity * Time.deltaTime, 0);
        if(started) {
            rb.AddForce(forwardForce * Time.deltaTime, 0, 0);
        }

        if(rb.velocity.y < 0) {
          isGoingUp = false;
        }

        if (rb.velocity.x > 10) {
            rb.AddForce(-forwardForce * Time.deltaTime, 0, 0);
        }
        
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }

    void Update() {
        if(Input.GetKey("d")) {
            started = true;
        }
        


        if(Input.GetKeyDown("s")) {
            rb.Sleep();
            rb.AddForce( forwardForce * Time.deltaTime, -downwardForce * Time.deltaTime, 0);
        }

    }

    void OnCollisionEnter(Collision collision)
    {

        if(!isGoingUp) {
            rb.AddForce(0, upwardForce * Time.deltaTime, 0);
        }
        isGoingUp = true;
        
        GlobalClass.isGoingDown = false;
   
    }

    // void OnCollisionEnter(Collision collisionInfo) {

    // }

}