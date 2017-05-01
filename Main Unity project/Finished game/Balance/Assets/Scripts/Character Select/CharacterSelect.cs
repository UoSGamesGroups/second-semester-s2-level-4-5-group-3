using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour {

    public Sprite[] Sprites;
    public int CurrentIndex = 0;
    public SpriteRenderer SpriteRender;

    void Start()
    {
        CurrentIndex = PlayerPrefs.GetInt("CharacterSelected");
    }

    public void ToggleLeft()
    {
        CurrentIndex--;

        if(CurrentIndex < 0)
            CurrentIndex = Sprites.Length - 1;

        UpdateCharacter();
    }

    public void ToggleRight()
    {
        CurrentIndex++;

        if(CurrentIndex >= Sprites.Length)
            CurrentIndex = 0;

        UpdateCharacter();
    }

    public void Confirm()
    {
        PlayerPrefs.SetInt("CharacterSelected", CurrentIndex);
        SceneManager.LoadScene("SelectTimer");
    }

    public void UpdateCharacter()
    {
        SpriteRender.sprite = Sprites[CurrentIndex];
    }
}
