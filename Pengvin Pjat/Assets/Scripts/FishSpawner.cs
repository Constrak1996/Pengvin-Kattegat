using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    private float nextSpawnTime;

    [SerializeField]
    private GameObject fishPrefab;
    [SerializeField]
    private float spawnDelay;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (ShouldSpawn())
        {
            Spawn();
        }
    }

    private void Spawn()
    {
        nextSpawnTime = Time.time + spawnDelay;
    }

    private bool ShouldSpawn()
    {
        return Time.time > nextSpawnTime;
    }
}
