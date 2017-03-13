using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreAndTagChange : MonoBehaviour
{

    public int playerOneScore;
    public Text score1;

    void Start()
    {
        playerOneScore = 0;
    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Items" || col.gameObject.tag == "p1")
        {
            playerOneScore += 1;
            this.gameObject.transform.tag = "Collided";
        }
    }

    void Update()
    {
        score1.text = playerOneScore.ToString();
    }
}
