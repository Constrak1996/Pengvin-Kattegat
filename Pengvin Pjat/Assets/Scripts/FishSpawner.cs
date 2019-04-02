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

    public Transform objectA;
    public Transform objectB;

    private int spriteType;
    private SpriteRenderer spriteRenderer;
    public Sprite[] fish = new Sprite[3];

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Object A's position is Object B's position
        objectA.position = objectB.position;
        objectA.parent = objectB;

        if (ShouldSpawn())
        {
            Spawn();
        }
    }

    private void Spawn()
    {
        nextSpawnTime = Time.time + spawnDelay;
        GameObject clone = Instantiate(fishPrefab, transform.position, transform.rotation);
        spriteRenderer = clone.GetComponent<SpriteRenderer>();
        spriteType = UnityEngine.Random.Range(0, 3);
        spriteRenderer.sprite = fish[spriteType];
    }

    private bool ShouldSpawn()
    {
        return Time.time > nextSpawnTime;
    }
}
