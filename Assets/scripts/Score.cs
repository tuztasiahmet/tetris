using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text scoreText;
    public static int score;
    string temp;

    private void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
    }
    public int GameScore()
    {
        return score;
    }
    private void Update()
    {
        temp = score.ToString();
        scoreText.text = temp;
    }
}
