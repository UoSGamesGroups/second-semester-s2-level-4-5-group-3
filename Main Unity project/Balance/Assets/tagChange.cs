using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tagChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void onCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag == "p1")
        {
            col.gameObject.transform.tag = "Collided";
            Debug.Log(col.gameObject.tag);
        }
		
	}
}
