using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadScore : MonoBehaviour
{
    private int score;
    public Text scoreText;

    private float time;
    public Text timeText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {        
        score = ScoreManager.getScore();      
        scoreText.text = score.ToString();

        time = TimeManager.getTime();
        timeText.text = $"{time:N2}";
    }
}
