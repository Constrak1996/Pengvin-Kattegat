using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SixPackTrashMovement : MonoBehaviour
{
    public Transform target;

    private float speed = -0.015f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed, 0, 0);

        if (transform.position.x <= -12)
        {
            Destroy(gameObject);
        }

        if (PlayerMovement.slowed is true)
        {
            gameObject.transform.position += target.transform.position * Time.deltaTime;
        }
    }
}
