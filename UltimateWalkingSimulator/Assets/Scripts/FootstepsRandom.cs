using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepsRandom : MonoBehaviour {

    public PlayerMovement myPlayer;

    public AudioSource[] footsteps;
    public int howManySteps;
    public int stepNumber;
    public float timer;
    public float stepTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetAxis("Horizontal") >= 0.01f || Input.GetAxis("Horizontal") <= -0.01f)
        {
            stepNumber = Random.Range(0, howManySteps);
            timer += Time.deltaTime;
            if (timer >= stepTime)
            {
                footsteps[stepNumber].Play();
                timer = 0;
            }
        }
	}
}
