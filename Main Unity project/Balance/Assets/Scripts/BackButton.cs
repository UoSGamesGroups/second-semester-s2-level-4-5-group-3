using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour {

	public void BackBtn(string Back)
	{
		SceneManager.LoadScene (Back);
	}

}