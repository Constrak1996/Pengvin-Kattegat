using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkDamage : MonoBehaviour
{
    bool attackAble = true;

    private void OnTriggerEnter2D(Collider2D other)
    {
<<<<<<< HEAD
        DamageCooldown();
=======
>>>>>>> master
        if (other.tag == "Shark")
        {
            Health.health -= 1;
            DamageCooldown();
        }
        
    }

    IEnumerator DamageCooldown()
    {
        attackAble = false;
        yield return new WaitForSeconds(2);
        attackAble = true;
    }
}
