using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;             //Floating point variable to store the player's movement speed.

    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.

    Vector2 movement;
    float rotSpeed = 0.33f;
    float rotZ;
    float lerpTime = 5f;
    float currentLerpTime;
    int maxRot = 100;

    // Use this for initialization
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxisRaw("Horizontal");

        //Store the current vertical input in the float moveVertical.
        float moveVertical = Input.GetAxisRaw("Vertical");

        //Use the two store floats to create a new Vector2 variable movement.
        movement = new Vector2(moveHorizontal, moveVertical);

        //Rotate penguin 15 degrees up and down based on input and default to 0 once no input is detected
        rotZ += movement.y * rotSpeed;
        rotZ = Mathf.Clamp(rotZ, -maxRot, maxRot);

        if (moveVertical > 0 || moveVertical < 0)
        {
            currentLerpTime = 0f;
        }
        currentLerpTime += Time.deltaTime;
        if (currentLerpTime > lerpTime)
        {
            currentLerpTime = lerpTime;
        }
        
        float percent = currentLerpTime / lerpTime;
        rotZ = Mathf.Lerp(rotZ, 0, percent);
        transform.eulerAngles = new Vector3(0, 0, rotZ);

        //transform.eulerAngles = new Vector3(0, 0, rotZ);

    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
        rb2d.AddForce(movement.normalized * speed);
    }
}
