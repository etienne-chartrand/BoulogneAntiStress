using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{
    private float fadeSpeed = 1;
    public GameObject cube;

    public static bool activatePaper = false;

    void Update()
    {
        //FadeOut lorsque le timer est a 75%
        if ((Timer.timer / 2) * 1.5 <= Timer.middleTimer)
        {
            Color objectColor = cube.GetComponent<Renderer>().material.color;
            float fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);
            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            cube.GetComponent<Renderer>().material.color = objectColor;
        }
    }
}
