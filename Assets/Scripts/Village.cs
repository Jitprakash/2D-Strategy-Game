using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//! giving the village the functionality to sapwn a certain number of WOrkers
public class Village : MonoBehaviour
{
    public GameObject workerPrefab;
    public Transform spawnPoint;

    public float timeBetweenSpawn;
    float nextSpawnTime;
    public int numberOfWorkersToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time>nextSpawnTime)//! a time mechanism between which a worker will be spawned
        {
            nextSpawnTime = Time.time + timeBetweenSpawn;
            Instantiate(workerPrefab, spawnPoint.position,  Quaternion.identity);
            numberOfWorkersToSpawn--;
            if (numberOfWorkersToSpawn<=0)
            {
                Destroy(gameObject);
            }
        }
    }
}
