using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOutSecond : MonoBehaviour
{
    private float fadeSpeed = 1;
    public static bool firstIsOut = false;
    public static bool secondIsOut = false;
    public static bool thirdIsOut = false;

    public GameObject cube;

    private void Update()
    {
        if (Timer.timer <= Timer.middleTimer)
        {
            Color objectColor = cube.GetComponent<Renderer>().material.color;
            float fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);
            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            cube.GetComponent<Renderer>().material.color = objectColor;
        }
    }
}
