using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnScript : MonoBehaviour
{
    public GameObject obstacle;

    private float newSpawnRate = 10;

    private float rndY;

    private Vector2 whereToSpawn;

    private float spawnRate = 5;

    private float nextSpawn = 0.0f;

    public Texture2D[] obstacles = new Texture2D[5];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            rndY = Random.Range(-6.5f, 1.5f);
            whereToSpawn = new Vector2(transform.position.x, rndY);
            Instantiate(obstacle, whereToSpawn, Quaternion.identity);
        }

        if (Time.deltaTime > newSpawnRate && spawnRate > 0)
        {
            spawnRate -= 0.5f;
            newSpawnRate += 10;
        }

    }
}
