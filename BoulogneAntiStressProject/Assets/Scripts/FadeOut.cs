using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{
    private float fadeSpeed = 1;
    public static bool firstIsOut = false;
    public static bool secondIsOut = false;
    public static bool thirdIsOut = false;

    public GameObject cube;

    private void Update()
    {
        if (firstIsOut)
        {
            Color objectColor = cube.GetComponent<Renderer>().material.color;
            float fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            cube.GetComponent<Renderer>().material.color = objectColor;
        }

        if ((Timer.timer / 2) * 1.5 <= Timer.middleTimer)
        {

        }
        if (Timer.timer <= Timer.middleTimer)
        {

        }
        if (Timer.timer <= Timer.minTimer)
        {

        }



    }
}
