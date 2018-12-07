using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FadeText : MonoBehaviour {

    public Achievement myAchievement;

    public TMP_Text text;
    public Image banner;
    

    public bool fadingOut;
    public bool fadingIn;
    public float timeBetweenFade;
    public float startTimeBetweenFade;
    public float fadeTime;
    Color imageAlpha;

    private void Start()
    {
        timeBetweenFade = startTimeBetweenFade;
        imageAlpha = banner.color;
        //imageAlpha.a = 1f; //1f makes it fully visible, 0f makes it fully transparent.
        banner.color = new Color(banner.color.r, banner.color.g, banner.color.b, imageAlpha.a);
    

}
    private void Update()
    {
        banner.color = new Color(banner.color.r, banner.color.g, banner.color.b, imageAlpha.a);
        if (myAchievement.finishGame == false)
        {
            if (timeBetweenFade >= 1.25)
            {
                fadingIn = false;
                fadingOut = true;
            }
        }
        if (myAchievement.finishGame == true)
        {
            if (timeBetweenFade >= 30)
            {
                fadingIn = false;
                fadingOut = true;
            }
        }

        if (timeBetweenFade < 0)
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
        if(fadingIn == false && fadingOut == false && fadeTime > 0 && fadeTime < 1.20f)
        {
            imageAlpha.a = 0f;
        }

    } 

    void TimeFadeOut()
    {
        timeBetweenFade -= Time.deltaTime;
        text.alpha = timeBetweenFade;
        imageAlpha.a = timeBetweenFade;
        
    }

    void TimeFadeIn()
    {
        timeBetweenFade += Time.deltaTime;
        text.alpha = timeBetweenFade;
        imageAlpha.a = timeBetweenFade;
    }



}
