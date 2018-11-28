using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour {

    public Achievement myAchievement;

    private Rigidbody2D myRB;
    [Header("Movement settings ")]
    public GameObject player;
    public float speed = 13f;
    public float jumpforce = 850f;
  
    [Header("Distance to surface Settings")]
    public float distToGround = 1.1f;
    [Tooltip("Match with the surfaces layer.")]
    public LayerMask groundLayer;
    public bool grounded;
    public bool haveMoved = false;
    public bool haveJumped = false;

    public bool canMove = false;
    private float moveStoppingTimer;

    public float startMoveStoppingTimer;
    public bool jumpedOnce = false;

    

    private float fallTime = 0.2f;

    public void Awake()
    {
        myRB = GetComponent<Rigidbody2D>();
        moveStoppingTimer = startMoveStoppingTimer;
        canMove = true;
    }
    public  void Update()
    {
        if(canMove == false)
        {
            moveStoppingTimer -= Time.deltaTime;
        }
        else
        {
            moveStoppingTimer = startMoveStoppingTimer;
        }

        if(moveStoppingTimer <= 0)
        {
            canMove = true;
        }

    }

    void JumpFun()
    {
        grounded = Physics2D.Raycast(transform.position, Vector2.down, distToGround, groundLayer);

        if (grounded) myRB.velocity = Vector2.zero;

        if (Input.GetKeyDown(KeyCode.Space) && grounded == true)
        {
            myRB.AddForce(Vector2.up * jumpforce);         //To stop player from sticking to walls when jumpping add a physics material with 0 on all then "Friction Combine" to minimum
            haveJumped = true;
        }
   
        if (grounded == false)   //checking if grounded
        {
            FallFunc();
        }
        else
        {
            fallTime = 0.5f;
        }
    }

    void FixedUpdate () {

        if (canMove == true)
        {
            Movement();
        }        
        if (!jumpedOnce)
        {
            JumpFun();
        }

    }
    
    void Movement()
    {
        float moveX = Input.GetAxis("Horizontal");

        Vector3 moveVector = new Vector3(moveX, 0, 0) * (Time.deltaTime * speed);
        this.transform.Translate(moveVector, Space.World);
        haveMoved = true;
    }

    void FallFunc()
    {
        fallTime -= Time.deltaTime;

        if (fallTime < -0.02f)
        {
            myRB.AddForce(Vector3.down * 4f);
        }
        if (fallTime < -0.10f)
        {
            myRB.AddForce(Vector3.down * 5f);
        }

    }

}
