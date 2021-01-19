using UnityEngine;

public class spawner : MonoBehaviour
{
    public float spawnDelay = .3f;
    public GameObject enemy;
    public Transform[] SpawnPoints;
    float nextTimeToSpawn = 0f;
    [SerializeField]
    private float _speed = 4f;

    void Update ()
    {
        // transform.Translate(Vector3.down * _speed * Time.deltaTime);
        // if(transform.position.y < -4f)
        // {
        //     transform.position = new Vector3(transform.position.x,12.5f,transform.position.z);
        // }
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
