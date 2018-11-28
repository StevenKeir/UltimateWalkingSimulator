using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FadeText : MonoBehaviour {


    public TMP_Text text;
    

    public bool fadingOut;
    public bool fadingIn;
    public float timeBetweenFade;
    public float startTimeBetweenFade;
    public float fadeTime;

    private void Start()
    {
        timeBetweenFade = startTimeBetweenFade;

    }
    private void Update()
    {
        if(timeBetweenFade >= 1)
        {
            fadingIn = false;
            fadingOut = true;
        }

        if(timeBetweenFade < 0)
        {
            fadingOut = false;
            
            timeBetweenFade = startTimeBetweenFade;
        }


        if (fadingOut == true && fadingIn == false)
        {
            TimeFadeOut();
        }
        if (fadingIn == true && fadingOut == false)
        {
            TimeFadeIn();
        }
        if(fadingIn == true && fadingOut == true)
        {
            fadingIn = false;
            fadingOut = false;
        }

    } 

    void TimeFadeOut()
    {
        timeBetweenFade -= Time.deltaTime / fadeTime;
        text.alpha = timeBetweenFade;        
    }

    void TimeFadeIn()
    {
        timeBetweenFade += Time.deltaTime / fadeTime;
        text.alpha = timeBetweenFade;
    }



}
