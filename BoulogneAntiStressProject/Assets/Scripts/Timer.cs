using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    private float timer = 1200;
    private float maxtimer;
    private float minTimer;
    private float middleTimer;

    public Text countDownText;
    public InputField timerSettings;

    public GameObject firstCube;
    public GameObject secondCube;
    public GameObject thirdCube;

    private void Start()
    {
        GetTimer();

        maxtimer = timer;
        middleTimer = maxtimer / 2;
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

        if ((timer/2)* 1.5 <= middleTimer )
        {
            firstCube.SetActive(false);
        }
        if(timer <= middleTimer)
        {
            secondCube.SetActive(false);
        }
        if(timer <= minTimer)
        {
            thirdCube.SetActive(false);
        }
    }

    public void GetTimer()
    {
        float t = float.Parse(timerSettings.text);
        timer = t;
    }
}
