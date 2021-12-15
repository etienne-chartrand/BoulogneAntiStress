using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCookie : MonoBehaviour
{

    public bool CreatingCookie = false;
    public static int CookieIncrease = 1;
    public int InternalIncrease;

    void Update()
    {
        InternalIncrease = CookieIncrease;

        if(CreatingCookie == false)
        {
            CreatingCookie = true;
            StartCoroutine(CreateTheCookie());
        }
    }

    IEnumerator CreateTheCookie()
    {
        GlobalCookies.CookieCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingCookie = false;
    }


}
