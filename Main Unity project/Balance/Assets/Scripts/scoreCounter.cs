using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreCounter : MonoBehaviour {

    public int playerOneScore;
    public Text score1;
    public bool addScore;
 
    void Start ()
    {
        playerOneScore = 0;
        addScore = false;
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        addScore = false;
        if (col.gameObject.tag == "Items" & !addScore)
        {
            
            playerOneScore += 1;
            addScore = true;
        }
    }

        void Update ()
    {
        score1.text = playerOneScore.ToString();

	}
}
