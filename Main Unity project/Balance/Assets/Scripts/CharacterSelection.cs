using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour {

	private List<GameObject> characters;
	private int selectionIndex = 0; 


	private void Start()

	{
		characters = new List<GameObject> ();
		foreach (Transform t in transform) 
		{
			characters.Add (t.gameObject);
			t.gameObject.SetActive (false);
		}

		characters [selectionIndex].SetActive (true);
	}

	private void Update()
	{
		
	}

	public void Select(int index)
	{
		if (index == selectionIndex)
			return; 
		if (index < 0 || index >= characters.Count)
			return;
		characters [selectionIndex].SetActive (false);
		selectionIndex = index;
		characters [selectionIndex].SetActive (true);
	}

	public void ConfirmButton()
	{
		SceneManager.LoadScene ("SelectTimer");
	}
}