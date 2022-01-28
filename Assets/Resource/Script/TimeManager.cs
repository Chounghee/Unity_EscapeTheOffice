using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text timeText;
    static private float time;

    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    private void Update()
    {
        time += Time.deltaTime;
        timeText.text = $"{time:N2}";
    }   
    static public float getTime()
    {
        return time;
    }

}
