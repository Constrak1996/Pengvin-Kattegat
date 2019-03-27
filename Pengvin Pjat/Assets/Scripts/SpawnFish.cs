using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFish : MonoBehaviour
{
    private float nextSpawnTime;

    [SerializeField]
    private GameObject fishPrefab;
    [SerializeField]
    private float spawnDelay = 10;

    public Transform objectA;
    public Transform objectB;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Make ObjectA's position match objectB
        objectA.position = objectB.position;

        //Now parent the object so it is always there
        objectA.parent = objectB;

        if (ShouldSpawn())
        {
            Spawn();
        }
    }

    private void Spawn()
    {
        nextSpawnTime = Time.time + spawnDelay;
        Instantiate(fishPrefab);
    }

    private bool ShouldSpawn()
    {
        return Time.time >= nextSpawnTime;
    }
}
