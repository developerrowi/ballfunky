using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.iOS;
public class BallMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;

    public Transform player;
    public bool started = true;

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

        if (rb.velocity.x > GlobalClass.speedCount) {
            rb.AddForce(-forwardForce * Time.deltaTime, 0, 0);
        }

        if (player.position.y > 10) {
            rb.AddForce(0, -upwardForce/20 * Time.deltaTime, 0);
        }
        
    }

    void Update() {
        if(Input.GetKey("d")) {
            started = true;
        }
        


        if(Input.GetKeyDown("s")) {
            // rb.Sleep();
            rb.AddForce( 0, -downwardForce * Time.deltaTime, 0);
        }

         if (Input.touchCount > 2)
            {
                started = true;
                rb.AddForce( 0, -downwardForce * Time.deltaTime, 0);
            }

    }

    void OnCollisionEnter(Collision collision)
    {

        
        Debug.Log("Collided" + rb.position.y);


        if(!isGoingUp) {
            rb.AddForce(0, upwardForce * Time.deltaTime, 0);
        }
        isGoingUp = true;
        
        GlobalClass.isGoingDown = false;
   
    }

}
