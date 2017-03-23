using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuBehaviour : MonoBehaviour {


	public void NewGameBtn(string StartGame)
		{
		SceneManager.LoadScene (StartGame);
		}

	public void ExitGameBtn()
	{
		Application.Quit ();
	}

}