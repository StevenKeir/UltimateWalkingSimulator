using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSwap : MonoBehaviour {

    public Sprite greenLight; 
    public Sprite redLight;
    public SpriteRenderer spriteRenderer;
    public float startTime;
    public float currentTime;
    public bool switchLight;
    public Collider2D thisCol;

	// Use this for initialization
	void Start () {

        currentTime = startTime;
        
	}
	
	// Update is called once per frame
	void Update () {

        currentTime -= Time.deltaTime;

        if(currentTime <= 0 && switchLight == true)
        {
            switchLight = false;
            currentTime = startTime;
        }
        if (currentTime <= 0 && switchLight == false)
        {

            switchLight = true;
            currentTime = startTime;
        }

        if(switchLight == true)
        {
            spriteRenderer.sprite = redLight;
            thisCol.enabled = true;
        }
        if (switchLight == false)
        {
            spriteRenderer.sprite = greenLight;
            thisCol.enabled = false;

        }

	}

}
