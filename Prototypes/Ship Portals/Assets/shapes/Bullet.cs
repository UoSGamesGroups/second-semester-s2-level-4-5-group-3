using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    void Start () {
       
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(1, 0, Time.deltaTime);
        transform.Translate(0, Time.deltaTime, 0, Space.World);
    }


    void OnTriggerEnter2D(Collider2D Wall)

    {
        Destroy(gameObject);
    }

}
