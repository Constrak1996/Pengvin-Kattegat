﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawnerScript : MonoBehaviour
{
    public GameObject obstacle;

    private float newSpawnRate = 15;

    private float rndY;

    private Vector2 whereToSpawn;

    private float spawnRate = 8;

    private float nextSpawn = 0.0f;

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
            rndY = Random.Range(-7f, 1.3f);
            whereToSpawn = new Vector2(transform.position.x, rndY);
            Instantiate(obstacle, whereToSpawn, Quaternion.identity);
        }
    }
}
