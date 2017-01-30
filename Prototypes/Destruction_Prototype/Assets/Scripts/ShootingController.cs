using UnityEngine;
using System.Collections;

public class ShootingController : MonoBehaviour {

	public float speed; 
	public PlayerController player;

	public float rotationSpeed;


	// Use this for initialization
	void Start () 

	{
		player = FindObjectOfType<PlayerController> ();

		if (player.transform.localScale.x < 0) 
		
		{
			speed = -speed;

			rotationSpeed = -rotationSpeed;

		}
		
	}
	
	// Update is called once per frame
	void Update ()

	{
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed, GetComponent<Rigidbody2D> ().velocity.y);

		GetComponent<Rigidbody2D> ().angularVelocity = rotationSpeed;

	}




	void OnTriggerEnter2D(Collider2D other)

	{
		Destroy (gameObject);
	}

}
