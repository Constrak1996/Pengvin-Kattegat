using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private int health = 3;

    public int Health { get => health; set => health = value; }

    public int fishCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle")
        {
            Debug.Log("We hit an obstacle");
            Health--;
            Debug.Log(Health);
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "Fish")
        {
            fishCounter++;
            Debug.Log($"We caught a fish. fish counter: {fishCounter}");
            Destroy(collision.gameObject);
        }
    }
}
