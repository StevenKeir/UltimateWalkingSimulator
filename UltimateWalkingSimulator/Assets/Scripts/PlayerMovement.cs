using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour {

    private Rigidbody2D myRB;

    public GameObject player;
    public float speed = 13f;
    public float jumpforce = 850f;
    public bool grounded;
    public LayerMask groundLayer;
  
    public float distToGround = 1.1f;
    private float fallTime = 0.2f;

    public void Awake()
    {
        myRB = GetComponent<Rigidbody2D>();
    }
    public  void Update()
    {

        if (Input.GetKey(KeyCode.A) /*&& player.transform.rotation.y == 0*/)
        {
            player.transform.rotation = new Quaternion(0,180,0,1);
        }
        if (Input.GetKey(KeyCode.D) /*&& player.transform.rotation.y == 180.0f*/)
        {
            player.transform.rotation = new Quaternion(0, 0, 0, 1);
        }

            JumpFun();
            Debug.DrawLine(transform.position, transform.position + Vector3.down * distToGround, Color.red);

    }

    void JumpFun()
    {
        grounded = Physics2D.Raycast(transform.position, Vector2.down, distToGround, groundLayer);

        if (grounded) myRB.velocity = Vector2.zero;

        if (Input.GetKeyDown(KeyCode.Space) && grounded == true)
        {
            myRB.AddForce(Vector2.up * jumpforce);         //To stop player from sticking to walls when jumpping add a physics material with 0 on all then "Friction Combine" to minimum
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

            Movement();

    }
    
    void Movement()
    {
        float moveX = Input.GetAxis("Horizontal");

        Vector3 moveVector = new Vector3(moveX, 0, 0) * (Time.deltaTime * speed);
        this.transform.Translate(moveVector, Space.World);
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
