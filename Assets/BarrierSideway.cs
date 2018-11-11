using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierSideway : MonoBehaviour {
    int direction = 0;
    [SerializeField] float speed = 0.05f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(direction == 0)
        {
            if (transform.position.x < 3)
            {
                transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
            } 
            else
            {
                direction = 1;
            }
        }
        else
        {
            if (transform.position.x > -3)
            {
                transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
            }
            else
            {
                direction = 0;
            }
        }
	}
}
