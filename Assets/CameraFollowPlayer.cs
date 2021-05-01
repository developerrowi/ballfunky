using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
	public Transform player;	

    // Update is called once per frame

    void Update()
    {
        transform.position = new Vector3(player.position.x + 4, transform.position.y, transform.position.z);
    }
}
