using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject Timerstart;
    
    //active le timer GameObject
    public void StartAutoCookie()
    {
        Timerstart.SetActive(true);
    }
}
