using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    static private int score = 100;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    static public void setScore(int n)
    {
        score = n;
    }
    static public int getScore()
    {
        return score;
    }
}
