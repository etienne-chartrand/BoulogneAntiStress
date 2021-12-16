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

        if(timer > 0 && isPaused == false)
        {
            timer = Mathf.Max(0, timer - Time.deltaTime);
            var timeSpan = System.TimeSpan.FromSeconds(timer);
            countDownText.text = timeSpan.Hours.ToString("00") + ":" +
                            timeSpan.Minutes.ToString("00") + ":" +
                            timeSpan.Seconds.ToString("00") + "." +
                            timeSpan.Milliseconds / 100;
        }
        else if (isPaused == false && timer <= 0)
        {
            timer = 0;
        }

        if ((timer/2)* 1.5 <= middleTimer )
        {
            Color objectColor = firstCube.GetComponentInChildren<Renderer>().material.color;
            float fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);


            int numOfChildrens = transform.childCount;
            for(int i = 0; 1 <numOfChildrens; i++)
            {
                GameObject child = transform.GetChild(i).gameObject;
                //child.GetComponent<Renderer>().materials
            }


            

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            firstCube.GetComponentInChildren<Renderer>().material.color = objectColor;


        }
        if(timer <= middleTimer)
        {
            Color objectColor = secondCube.GetComponentInChildren<Renderer>().material.color;
            float fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            secondCube.GetComponentInChildren<Renderer>().material.color = objectColor;
        }
        if(timer <= minTimer)
        {
            Color objectColor = thirdCube.GetComponentInChildren<Renderer>().material.color;
            float fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            thirdCube.GetComponentInChildren<Renderer>().material.color = objectColor;
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
