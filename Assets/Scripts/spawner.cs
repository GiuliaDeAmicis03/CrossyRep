using UnityEngine;

public class spawner : MonoBehaviour
{
    public float spawnDelay = .3f;
    public GameObject enemy;
    public Transform[] SpawnPoints;
    float nextTimeToSpawn = 0f;

    void Update ()
    {
        if (nextTimeToSpawn <= Time.time) 
        {
            SpawnEnemy();
            nextTimeToSpawn = Time.time + spawnDelay;
        }
    }
    void SpawnEnemy ()
    {
        //SpawnPoints[0-3]
        int randomIndex = Random.Range(0, SpawnPoints.Length);
        Transform SpawnPoint = SpawnPoints[randomIndex];
        Instantiate(enemy, SpawnPoint.position, SpawnPoint.rotation);
    }
}
