using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject Timerstart;
    public GameObject inGameScene;
    public GameObject mainMenuScene;
    


    
    //active le timer GameObject
    public void StartAutoCookie()
    {
        Timerstart.SetActive(true);
        inGameScene.SetActive(true);
        
        mainMenuScene.SetActive(false);
    }
}
