using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FadeText : MonoBehaviour {


    public TMP_Text text;
    public Image textBackGround;

    public bool faded;
    public float TimeBetweenFade;

    private void Start()
    {
        faded = false;
        text.alpha = 0f;
        text.gameObject.SetActive(false);
        //imageAlpha = textBackGround.color;
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            text.gameObject.SetActive(true);
            //StartCoroutine(Fade());
            faded = true;
            
        }
        if (faded == true) { TimeFade(); }
    }

    void TimeFade()
    {
        TimeBetweenFade -= Time.deltaTime;
        text.alpha = TimeBetweenFade;
    }

    IEnumerator Fade()
    {
        var imageAlpha = textBackGround.color;
        textBackGround.color = imageAlpha;
        if (!faded)
        {
            text.alpha = 0.90f;
            imageAlpha.a = 0.90f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 0.80f;
            imageAlpha.a = 0.80f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 0.70f;
            imageAlpha.a = 0.70f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 0.60f;
            imageAlpha.a = 0.60f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 0.50f;
            imageAlpha.a = 0.50f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 0.40f;
            imageAlpha.a = 0.40f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 0.30f;
            imageAlpha.a= 0.30f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 0.20f;
            imageAlpha.a = 0.20f;
            yield return new WaitForSeconds(0.01f);            
            text.alpha = 0.10f;
            imageAlpha.a = 0.10f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 0.00f;
            imageAlpha.a = 0.00f;
            yield return new WaitForSeconds(TimeBetweenFade);
            faded = true;
           
            text.alpha = 0.00f;
            imageAlpha.a = 0.00f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 0.20f;
            imageAlpha.a = 0.20f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 0.30f;
            imageAlpha.a = 0.30f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 0.40f;
            imageAlpha.a = 0.40f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 0.50f;
            imageAlpha.a = 0.50f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 0.60f;
            imageAlpha.a = 0.60f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 0.70f;
            imageAlpha.a = 0.70f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 0.80f;
            imageAlpha.a = 0.80f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 0.90f;
            imageAlpha.a = 0.90f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 1f;
            imageAlpha.a = 1f;
            faded = false;
        }
        else
        {
            text.alpha = 0.00f;
            imageAlpha.a = 0.00f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 0.20f;
            imageAlpha.a = 0.20f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 0.30f;
            imageAlpha.a = 0.30f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 0.40f;
            imageAlpha.a = 0.40f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 0.50f;
            imageAlpha.a = 0.50f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 0.60f;
            imageAlpha.a = 0.60f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 0.70f;
            imageAlpha.a = 0.70f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 0.80f;
            imageAlpha.a = 0.80f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 0.90f;
            imageAlpha.a = 0.90f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 1f;
            imageAlpha.a = 1f;
            yield return new WaitForSeconds(TimeBetweenFade);
            faded = false;
           
            text.alpha = 0.90f;
            imageAlpha.a = 0.90f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 0.80f;
            imageAlpha.a = 0.80f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 0.70f;
            imageAlpha.a = 0.70f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 0.60f;
            imageAlpha.a = 0.60f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 0.50f;
            imageAlpha.a = 0.50f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 0.40f;
            imageAlpha.a = 0.40f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 0.30f;
            imageAlpha.a = 0.30f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 0.20f;
            imageAlpha.a = 0.20f;
            yield return new WaitForSeconds(0.01f);            
            text.alpha = 0.10f;
            imageAlpha.a = 0.10f;
            yield return new WaitForSeconds(0.01f);
            text.alpha = 0.00f;
            imageAlpha.a = 0.00f;
            faded = true;
            
            
        }

    }

}
