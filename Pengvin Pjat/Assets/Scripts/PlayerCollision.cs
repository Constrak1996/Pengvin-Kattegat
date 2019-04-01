using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Sets the players startposition, so we can use it to reset his position when taking damage
    Vector2 startPos;
<<<<<<< HEAD

    private float stunTime;

=======
    int fishHeal = 0;
>>>>>>> 2fd5921c1badb859d3aa54bef3601cbd1373e16c
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
            fishHeal++;
        }
        else if (collision.tag == "DeathWall")
        {
            Health.health--;
            gameObject.transform.position = startPos;
        }
        else if (fishHeal == 5)
        {
            Health.health += 1;
            fishHeal = 0;
        }
    }
}
