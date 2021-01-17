using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployEnemies : MonoBehaviour
{
    public GameObject SpawnPoint;
    float randY;
    Vector2 whereToSpawn;

    public float spawnRate = 1f;
    float nextSpawn = 0f;

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randY = Random.Range (5f, 16f);
            whereToSpawn = new Vector2 (randY, transform.position.x);
            Instantiate (SpawnPoint, whereToSpawn, Quaternion.identity);
        }
    }

}
