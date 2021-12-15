using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float timer = 1200;
    public Text countDownText;
    public InputField timerSettings;
    
    private void Start()
    {
        GetTimer();
    }


    void Update()
    {

        if(timer > 0)
        {
            timer = Mathf.Max(0, timer - Time.deltaTime);
            var timeSpan = System.TimeSpan.FromSeconds(timer);
            countDownText.text = timeSpan.Hours.ToString("00") + ":" +
                            timeSpan.Minutes.ToString("00") + ":" +
                            timeSpan.Seconds.ToString("00") + "." +
                            timeSpan.Milliseconds / 100;
        }
        else
        {
            timer = 0;
        }
        
    }

    void PrintDate()
    {
        Debug.Log("Date : " + System.DateTime.Now.ToString());
    }

    public void GetTimer()
    {
        float t = float.Parse(timerSettings.text);
        print(timerSettings.text);
        timer = t;
    }
}
