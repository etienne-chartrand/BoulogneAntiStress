using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private bool isPaused = false;
    private Material material;
    private float fadeSpeed = 2;

    public static float timer = 1200;
    public static float maxtimer;
    public static float minTimer;
    public static float middleTimer;

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

        if(timer > 0 && isPaused == false)
        {
            timer = Mathf.Max(0, timer - Time.deltaTime);
            var timeSpan = System.TimeSpan.FromSeconds(timer);
            countDownText.text = timeSpan.Hours.ToString("00") + ":" +
                            timeSpan.Minutes.ToString("00") + ":" +
                            timeSpan.Seconds.ToString("00");
                            //timeSpan.Milliseconds / 100;
        }
        else if (isPaused == false && timer <= 0)
        {
            timer = 0;
        }
    }

    public void GetTimer()
    {
        float t = float.Parse(timerSettings.text);
        timer = t;
    }

    public void PauseTimer()
    {
        isPaused = true;
    }

    public void ResumeTimer()
    {
        isPaused = false;
    }
}
