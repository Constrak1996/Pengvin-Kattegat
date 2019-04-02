using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupHealth : MonoBehaviour
{
    public GameObject healthPrefab;
    public float respawnTime;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(HealthWave());
    }

    private void SpawnHealth()
    {
        GameObject s = Instantiate(healthPrefab) as GameObject;
        s.transform.position = new Vector2(20, Random.Range(-5, 3));         
    }

    IEnumerator HealthWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnHealth();
        }
    }
}
