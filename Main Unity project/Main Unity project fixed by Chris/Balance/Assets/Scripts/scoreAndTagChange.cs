using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreAndTagChange : MonoBehaviour
{
    private const float PlayerDivide = 2.0f;

    public string playerTag = "p1";
    public int ScoreValue = 1;
    public int PenaltyScore = -2;
    public ScoreDisplay PlayerScore;

    public bool scored = false;

    void Start()
    {
        if (transform.position.x < PlayerDivide)
        {
            PlayerScore = GameObject.Find("p1 platform").GetComponent<ScoreDisplay>();
        }
        else
        {
            PlayerScore = GameObject.Find("p2 platform").GetComponent<ScoreDisplay>();
            playerTag = "p2";
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (scored)
            return;

        if (col.gameObject.tag == "Items" || col.gameObject.tag == playerTag)
        {
            PlayerScore.AddScore(ScoreValue);
            scored = true;
        } 
        if (col.gameObject.tag == "cars")
        {
            PlayerScore.AddScore(PenaltyScore);
            scored = true;
        }
    }
}
