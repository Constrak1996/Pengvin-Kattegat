using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpeed : MonoBehaviour
{
    public GameObject speedPrefab;
    public float respawnTime = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(HealthWave());
    }

    private void SpawnSpeed()
    {
        GameObject s = Instantiate(speedPrefab) as GameObject;
        s.transform.position = new Vector2(20, Random.Range(-5, 3));
    }

    IEnumerator HealthWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnSpeed();
        }
    }
}
