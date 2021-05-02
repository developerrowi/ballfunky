using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class BallMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;

    public Transform player;
    public bool started = false;

    private bool isGoingUp = false;
    public float forwardForce = 500f; 

    public float upwardForce = 20100f; 
    
    public float customGravity = 1000f;
    public float downwardForce = 10000f;

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
        

        if (player.position.y > 10) {
            rb.AddForce(0, -upwardForce/20 * Time.deltaTime, 0);
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

        if(Input.touchCount > 0)
         {
             Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                // Record initial touch position.
                case TouchPhase.Began:
                    started = true;
                    rb.AddForce( 0, -downwardForce * Time.deltaTime, 0);
                    break;


                // case TouchPhase.Moved:
                //     direction = touch.position - startPos;
                //     break;


                // case TouchPhase.Ended:
                //     directionChosen = true;
                //     break;
            }

         }

    }

    void OnCollisionEnter(Collision collision)
    {

        if(!isGoingUp || player.position.y > 3.5) {
            rb.AddForce(0, upwardForce * Time.deltaTime, 0);
        }
        isGoingUp = true;
        
        GlobalClass.isGoingDown = false;
   
    }

}
