using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerSelect : MonoBehaviour {

	public void Start30(string Start30)
	{
		SceneManager.LoadScene ("SceneOne30");
	}

	public void Start60(string Start60)
	{
		SceneManager.LoadScene ("Scene one");
	}

	public void Start120(string Start120)
	{
		SceneManager.LoadScene ("SceneOne120");
	}

}
