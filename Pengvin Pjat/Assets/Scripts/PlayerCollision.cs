using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    Vector2 startPos;
    int fishHeal = 0;
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
