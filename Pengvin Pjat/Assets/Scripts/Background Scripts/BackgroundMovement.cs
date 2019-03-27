using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    private bool Right;
    private bool Left;
    private float patrolTime;

    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.
    public float speed;

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
        float moveLeft = speed;

        //Keeps track of time
        patrolTime += Time.deltaTime;

        //Use the two store floats to create a new Vector2 variable movement.
        Vector2 movementLeft = new Vector2(moveLeft, 0);


        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
        rb2d.AddForce(movementLeft);

        if (transform.position.x <= -17.64506)
        {
            transform.Translate(40, 0, 0);
        }
    }
}
