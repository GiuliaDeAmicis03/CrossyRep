using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployEnemies : MonoBehaviour
{
    public GameObject Camera;
    [SerializeField]
    private float MainCamera_Y;
    float randY;
    Vector2 whereToSpawn;

    public float spawnRate = 1f;
    float nextSpawn = 0f;

    void Update()
    {
        // if (Time.time > nextSpawn)
        // {
        //     nextSpawn = Time.time + spawnRate;
        //     randY = Random.Range (5f, 16f);
        //     whereToSpawn = new Vector2 (randY, transform.position.x);
        //     Instantiate (SpawnPoint, whereToSpawn, Quaternion.identity);
        // }
        MainCamera_Y = Camera.transform.position.y - 4;
        if(MainCamera_Y > transform.position.y)
        {
            transform.position = new Vector2(transform.position.x,transform.position.y + 10f);
            //transform.position = new Vector2(transform.position.x,maincamera_Y_top + 7 )
        }
    }
}
