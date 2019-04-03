using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NevalMinemovment : MonoBehaviour
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

            if (transform.position.x <= -13)
            {
                Destroy(gameObject);
            }
        }
        else
        {

        }

    }
}