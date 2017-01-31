using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {
    public GameObject bullet;
    public Transform Shoot_Position;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (Input.GetKey(KeyCode.E))
        {
            Instantiate(bullet, Shoot_Position.position, Shoot_Position.rotation);
        }

    }
}
