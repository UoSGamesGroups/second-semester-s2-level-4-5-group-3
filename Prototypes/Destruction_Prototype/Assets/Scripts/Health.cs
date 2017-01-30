using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Health : MonoBehaviour {

	public static int playerHealth;
	public int maxPlayerHealth;

	Text text;

	// Use this for initialization
	void Start () 
	{
		text = GetComponent<Text> (); 
		playerHealth = maxPlayerHealth; 
	}
	
	// Update is called once per frame
	void Update () 
	{
		text.text = "" + playerHealth; 
	}



public static void hurtPlayer(int damage)

	{
		playerHealth -= damage;
	}

	public void FullHealth()
	{
		playerHealth = maxPlayerHealth; 
	}
}