using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreCounter2 : MonoBehaviour {

    public int playerTwoScore;
    public Text score2;



    void Start()
    {
        playerTwoScore = 0;

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Items")
        {
            playerTwoScore += 1;
        }
    }

    void Update()
    {
        score2.text = playerTwoScore.ToString();

    }
}

