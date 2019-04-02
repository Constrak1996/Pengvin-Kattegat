using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Sets the players startposition, so we can use it to reset his position when taking damage
    Vector2 startPos;

    private float stunTime;

<<<<<<< HEAD
    int fishHeal = 0;

=======
>>>>>>> master
    // Start is called before the first frame update
    void Start()
    {
        startPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle")
        {
            PlayerMovement.stunned = true;
        }
        else if (collision.tag == "Fish")
        {
            Score.score++;
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "DeathWall")
        {
            Health.health--;
            gameObject.transform.position = startPos;
        }
<<<<<<< HEAD
        else if (fishHeal == 5)
        {
            Health.health += 1;
            fishHeal = 0;
        }
        else if (collision.tag == "SixPackTrash")
        {
            PlayerMovement.slowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "SixPackTrash")
        {
            PlayerMovement.slowed = false;
        }
=======
>>>>>>> master
    }
}
