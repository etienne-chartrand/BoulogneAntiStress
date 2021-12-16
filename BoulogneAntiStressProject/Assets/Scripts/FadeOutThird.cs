using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOutThird : MonoBehaviour
{
    private float fadeSpeed = 1;
    public GameObject cube;

    private void Update()
    {   
        //FadeOut lorsque le timer est fini
        if (Timer.timer <= Timer.minTimer)
        {
            Color objectColor = cube.GetComponent<Renderer>().material.color;
            float fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);
            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            cube.GetComponent<Renderer>().material.color = objectColor;
        }

        if (Timer.isInGame == false)
        {
            Color objectColor = cube.GetComponent<Renderer>().material.color;
            float fadeAmount = objectColor.a + (fadeSpeed / Time.deltaTime);
            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            cube.GetComponent<Renderer>().material.color = objectColor;
        }
    }
}
