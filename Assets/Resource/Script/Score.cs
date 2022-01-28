using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float score = 0.0f;

    static public int Level = 1;
    private int maxLevel = 5;
    private int scoreLevel = 100;

    public Text scoreText;

    public Text levelScore;

    static public int num = 1;
    
    void Awake()
    {
        
    }
    void Start()
    {
        score = 0.0f;
        Level = 0;
        num = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(score >= scoreLevel)
        {
            LevelUP();
        }
        //score += Time.deltaTime;
        scoreText.text= ((int)score).ToString();

        
        LevelSceen();
        ScoreManager.setScore((int)score);      
    }
    void LevelUP()
    {
        if (Level == maxLevel)
            return;

        scoreLevel *= 2;
        Level++;

        GetComponent<HeadMove>().SetSpeed();
        
    }
    public void coin()
    {
        score += 10.0f;
        
    }
    public void LevelSceen()
    {
        //Debug.Log("level: " + Level);
        levelScore.text = ((int)Level).ToString();
        
    }
   



}
