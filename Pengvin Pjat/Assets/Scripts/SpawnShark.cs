using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShark : MonoBehaviour
{
    public GameObject sharkPrefab;
    public float respawnTime = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(sharkWave());
    }

    private void SpawnEnemy()
    {
        GameObject s = Instantiate(sharkPrefab) as GameObject;
        s.transform.position = new Vector2(20, Random.Range(-5, 2));
    }

    IEnumerator sharkWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnEnemy();
        }
    }
}
