using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class countdownTimer : MonoBehaviour {

	public float cdTimer = 60; 
	public Text timerText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		cdTimer -= Time.deltaTime;
		timerText.text = cdTimer.ToString ("f2");
	    if (cdTimer <= 0)
	    {
	        timerText.text = "Game Over";
	    }

	}
}
