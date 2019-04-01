using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkDamage : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Health.health -= 1;
    }
}
