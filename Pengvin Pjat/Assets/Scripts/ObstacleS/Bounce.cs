using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public AnimationCurve myCurve;
    private float originalY;

    // Start is called before the first frame update
    void Start()
    {
        originalY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, originalY + myCurve.Evaluate((Time.time % myCurve.length)), transform.position.z);
    }
}
