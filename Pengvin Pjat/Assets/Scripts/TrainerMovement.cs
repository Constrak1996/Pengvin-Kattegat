using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainerMovement : MonoBehaviour
{
    private bool Right;
    private bool Left;
    private float patrolTime;
    private int flippedRight = 0;

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
        if (patrolTime > 0 && patrolTime < 14)
        {
            rb2d.AddForce(movementRight);
            while (flippedRight == 1)
            {
                this.transform.Rotate(0, 180, 0);
                flippedRight = 0;
            }       
        }

        if (patrolTime >= 15 && patrolTime < 29)
        {
            rb2d.AddForce(movementLeft);
            while (flippedRight == 0)
            {
                this.transform.Rotate(0, 180, 0);
                flippedRight = 1;
            }
        }

        if (patrolTime >= 29)
        {
            patrolTime = 0;
        }
    }
}
