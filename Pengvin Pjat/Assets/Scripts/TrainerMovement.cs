using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainerMovement : MonoBehaviour
{
    public float speed;             //Floating point variable to store the player's movement speed.
    private bool Right;
    private bool Left;
    public float patrolTime;

    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.

    // Use this for initialization
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D>();
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        //Store the current horizontal input in the float moveHorizontal.
        float moveRight = 20;
        float moveLeft = -20;

        //Keeps track of time
        patrolTime += Time.deltaTime;

        //Use the two store floats to create a new Vector2 variable movement.
        Vector2 movementRight = new Vector2(moveRight, 0);
        Vector2 movementLeft = new Vector2(moveLeft, 0);


        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
        if (patrolTime > 0 || patrolTime <= 10)
        {
            rb2d.AddForce(movementRight);
        }
        if (patrolTime >= 10)
        {
            rb2d.AddForce(movementLeft);
            patrolTime = 0;
        }
        
    }
}
