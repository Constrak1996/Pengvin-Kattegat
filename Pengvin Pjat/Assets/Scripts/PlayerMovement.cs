using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;             //Floating point variable to store the player's movement speed.

    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.

    Vector2 movement;
    float rotSpeed = 0.5f;
    float rotZ;
    float lerpTime = 5f;
    float currentLerpTime;
    int maxRot = 30;

    public Joystick joystick;

    // Use this for initialization
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //Reset our movement vector
        movement = Vector2.zero;

        //Variables to store our direction in
        float moveHorizontal = 0;
        float moveVertical = 0;

        //Input for PC
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");
        movement = new Vector2(moveHorizontal, moveVertical);
        movement.Normalize();

        //Inputs for mobile
        float joystickHorAbs = Mathf.Abs(joystick.Horizontal);
        float joystickVerAbs = Mathf.Abs(joystick.Vertical);

        if (joystickHorAbs >= 0.2f || joystickVerAbs >= 0.2f)
        {
            moveHorizontal = joystick.Horizontal;
            moveVertical = joystick.Vertical;
            movement = new Vector2(moveHorizontal, moveVertical);
            if (joystickHorAbs + joystickVerAbs > 1)
            {
                movement.Normalize();
            }
        }

        //Rotate penguin degrees up and down based on input and default to 0 once no input is detected
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
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
        rb2d.AddForce(movement * speed);
    }
}
