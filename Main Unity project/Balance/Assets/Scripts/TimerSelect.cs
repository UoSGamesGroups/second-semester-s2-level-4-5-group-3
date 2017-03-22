using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerSelect : MonoBehaviour {

	public void Start30(string Start30)
	{
		SceneManager.LoadScene (Start30);
	}

	public void Start60(string Start60)
	{
		SceneManager.LoadScene (Start60);
	}

	public void Start120(string Start120)
	{
		SceneManager.LoadScene (Start120);
	}

}
