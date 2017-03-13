using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuBehaviour : MonoBehaviour {

	public void Start()
	{
		//SceneManager.LoadScene ();
	}

	public void Exit()
	{
		Application.Quit ();
	}

	public void Help(string Help)

	{
		SceneManager.LoadScene (Help);
	}

}