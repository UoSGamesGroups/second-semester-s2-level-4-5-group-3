using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public int Score = 0;
    public Text ScoreText;

    void Start()
    {
        ScoreText.text = Score.ToString();
    }

    public void AddScore(int scoreAdd)
    {
        Score++;
        ScoreText.text = Score.ToString();
    }
}
