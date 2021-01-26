using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLoop : MonoBehaviour
//{
//    private float length, startpos, ypos;
//    public GameObject cam;
//    public float backgroundLoop;

//    void Start() 
//    {
//        startpos = transform.position.x;
//        ypos = transform.position.y;
//        length = GetComponent<SpriteRenderer>().bounds.size.y;
//    }

//    void Update() 
//    {
//        float temp = (cam.transform.position.y);
//        float dist = (cam.transform.position.x);
//        float ydist = (cam.transform.position.y);

//        transform.position = new Vector3(startpos + dist, ypos + ydist, transform.position.z);
//        if(temp > startpos + length) 
//        {
//            startpos += length;
//        }
//        else if(temp < startpos - length)
//        {
//            startpos -= length;
//        }
//    }
//}
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
        MainCamera_Y = Camera.transform.position.y - 12;
        if(MainCamera_Y > transform.position.y)
        {
            transform.position = new Vector2(transform.position.x,transform.position.y + 36f);
            //transform.position = new Vector2(transform.position.x,maincamera_Y_top + 7 )
        }
    }
}
