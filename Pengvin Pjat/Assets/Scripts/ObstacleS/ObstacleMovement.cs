using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1)
        {
            transform.Translate(speed, 0, 0);
        }
        else
        {

        }

        if (transform.position.x <= -12)
        {
            Destroy(gameObject);
        }
    }
}
