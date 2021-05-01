using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxRed : MonoBehaviour
{
    // Start is called before the first frame update
	public Rigidbody player;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        // print("collided");
        // if(GlobalClass.isGoingDown) {
        //   GlobalClass.isGoingDown = false;
        //   player.AddForce(0, 20100 * Time.deltaTime, 0);
        // }


    }


}
