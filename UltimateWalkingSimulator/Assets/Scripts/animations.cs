using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animations : MonoBehaviour
{

    Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxis("Horizontal") >= 0.05f)
        {
            anim.SetBool("walk", true);
        }
        else {
            anim.SetBool("walk", false);
        }

        if (Input.GetAxis("Horizontal") <= -0.05f)
        {
            anim.SetBool("walkleft", true);
        }
        else {
            anim.SetBool("walkleft", false);
        }

    }

}
