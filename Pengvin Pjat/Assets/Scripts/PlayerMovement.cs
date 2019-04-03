 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static float speed = 20;         //Floating point variable to store the player's movement speed.

    public float boostPower;

    public float ObstacleBounce;

    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.

    public static bool stunned;

    private float stunTime;

    public static bool slowed;

    private Vector2 direction;

    Vector2 movement;
    float rotSpeed = 1f;
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

        direction = rb2d.velocity;
        //direction.Normalize();


        //Reset our movement vector
        movement = Vector2.zero;

       
        if (stunned is false)
        {
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

            if (moveVertical > 0 || moveVertical < 0)
            {
                currentLerpTime = 0f;
            }
            currentLerpTime += Time.deltaTime;
            if (currentLerpTime > lerpTime)
            {
                currentLerpTime = lerpTime;
            }
           

            if (Input.GetKeyDown(KeyCode.Space))
            {
                GetComponent<Rigidbody2D>().AddForce(direction * boostPower, ForceMode2D.Impulse);
            }

        }
        if (stunned is true)
        {
            stunTime += Time.deltaTime;
            speed = 0;

            transform.Translate(-direction * Time.deltaTime * ObstacleBounce);

            if (stunTime > 1)
            {
                stunned = false;
                stunTime = 0;
                speed = 20;
            }
        }

        

        //Rotate penguin degrees up and down based on input and default to 0 once no input is detected
        rotZ += movement.y * rotSpeed;
        rotZ = Mathf.Clamp(rotZ, -maxRot, maxRot);
        float percent = currentLerpTime / lerpTime;
        rotZ = Mathf.Lerp(rotZ, 0, percent);
        transform.eulerAngles = new Vector3(0, 0, rotZ);

        if (slowed)
        {
            speed = 1;
        }
        else if (!slowed)
        {
            speed = 20;
        }

    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        if (stunned is false)
        {
            //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
            rb2d.AddForce(movement * speed);
        }
    }

}
