using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private bool isPaused = false;
    public static bool isInGame = false;
    private bool isInCourse = false;
    
    public static float timer = 1200;
    public static float maxtimer;
    public static float minTimer;
    public static float middleTimer;

    public Text countDownText;
    public InputField timerSettings;

    public GameObject mainMenuScene;
    public GameObject inGameScene;
    public GameObject bibliothequeScene;
    public GameObject insideCoursScene;
    public GameObject coursDetails;

    public GameObject PauseBtn;
    public GameObject ResumeBtn;
    public GameObject Student;

    private void Start()
    {
        GetTimer();   
        maxtimer = timer;
        middleTimer = maxtimer / 2;
    }

    void Update()
    {
        
        //update le timer
        if(timer > 0 && isPaused == false)
        {
            
            isInGame = true;
            timer = Mathf.Max(0, timer - Time.deltaTime);
            var timeSpan = System.TimeSpan.FromSeconds(timer);
            countDownText.text = timeSpan.Hours.ToString("00") + ":" +
                            timeSpan.Minutes.ToString("00") + ":" +
                            timeSpan.Seconds.ToString("00");
            //timeSpan.Milliseconds / 100;

            
        }
        else if (isPaused == false && timer <= 0 && isInCourse == false)
        {
            
            isInGame = false;
            timer = 0;
            mainMenuScene.SetActive(false);
            inGameScene.SetActive(false);
            bibliothequeScene.SetActive(true);
        }
    }


    //check ce que l'utilisateur a entrer comme timer
    public void GetTimer()
    {
        float t = float.Parse(timerSettings.text);
        timer = t * 60;
    }

    //arrete le timer
    public void PauseTimer()
    {
        isPaused = true;
        ResumeBtn.SetActive(true);
        PauseBtn.SetActive(false);
        //Student.SetActive(false);
    }

    //resume le timer
    public void ResumeTimer()
    {
        isPaused = false;
        PauseBtn.SetActive(true);
        ResumeBtn.SetActive(false);
        //Student.SetActive(true);
    }


    public void RestartApp()
    {
        isInCourse = false;
        timer = 10000;
        mainMenuScene.SetActive(true);
        inGameScene.SetActive(false);
        bibliothequeScene.SetActive(false);
        insideCoursScene.SetActive(false);
        coursDetails.SetActive(false);
        
    }

    public void OnClickCourses()
    {
        isInCourse = true;
        insideCoursScene.SetActive(true);
        bibliothequeScene.SetActive(false);
        coursDetails.SetActive(false);
        
    }
    
    public void BibliothequeBtn()
    {

        isInCourse = false;
        bibliothequeScene.SetActive(true);
        insideCoursScene.SetActive(false);
        mainMenuScene.SetActive(false);
        coursDetails.SetActive(false);
        
        
    }

    public void OpenDetails()
    {
        isInCourse = true;
        coursDetails.SetActive(true);
        insideCoursScene.SetActive(false);
        
        
    }
}
