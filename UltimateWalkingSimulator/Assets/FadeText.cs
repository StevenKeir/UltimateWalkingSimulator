using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FadeText : MonoBehaviour {


    public TMP_Text text;
    //public Image textBackGround;

    public bool fadingOut;
    public bool fadingIn;
    private float timeBetweenFade;
    public float fadeTime;

    private void Start()
    {
        fadingOut = false;
        fadingIn = false;

    }
    private void Update()
    {
        if(timeBetweenFade > 1)
        {
            timeBetweenFade = 1;
            fadingOut = false;
            fadingIn = false;
        }

        if(timeBetweenFade < 0)
        {
            timeBetweenFade = 0;
            fadingOut = false;
            fadingIn = false;
        }

        if (Input.GetKey(KeyCode.E) && fadingIn == false)
        {
            fadingOut = true;
        }
        if (Input.GetKey(KeyCode.R) && fadingOut == false)
        {
            fadingIn = true;
        }

        if (fadingOut == true && fadingIn == false)
        {
            TimeFadeOut();
        }
        if (fadingIn == true && fadingOut == false)
        {
            TimeFadeIn();
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
