using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;

    public float forwardForce = 500000f; 
    
    public float downwardForce = 25000f;
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    //    rb.AddForce(0,0, forwardForce * Time.deltaTime);
    }

    void Update() {
        if(Input.GetKey("d")) {
            rb.AddForce(500 * Time.deltaTime,0, 0);
        }

        if(Input.GetKey("a")) {
            rb.AddForce(-500 * Time.deltaTime,0, 0);
        }

        // if(Input.GetKeyDown("space")) {
        //     rb.AddForce(0, 30000 * Time.deltaTime, 0);
        // }

        // if(Input.GetKey("w")) {
        //     rb.AddForce(0,0, forwardForce * Time.deltaTime);
        // }

        if(Input.GetKeyDown("s")) {
            rb.AddForce(0, -downwardForce * Time.deltaTime, 0);
        }

        
    }
}
