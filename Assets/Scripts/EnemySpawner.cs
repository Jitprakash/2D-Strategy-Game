using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//! Spawning the enemy

public class EnemySpawner : MonoBehaviour
{
    public Transform[] enemySpawnPoint;
    public GameObject enemyPrefab;
    public float enemyTimebetweenSpawn;
    float enemyNextSpawnTime;
    public int maxEnemyCount;
     public int enemyCount=0;
    public static EnemySpawner enemyInstance;
    // Start is called before the first frame update
    void Start()
    {
        enemyInstance=this;
    }

    // Update is called once per frame
    void Update()
    {
        // if (enemyCount > maxEnemyCount)
        // {
        //     enemyCount=0;
        // }
        if (Time.time>enemyNextSpawnTime && enemyCount<maxEnemyCount)
        {
            enemyNextSpawnTime =Time.time + enemyTimebetweenSpawn;
            Transform randomSpawnPoint = enemySpawnPoint[Random.Range(0,enemySpawnPoint.Length)];
            Instantiate(enemyPrefab, randomSpawnPoint.position ,Quaternion.identity);
            enemyCount++;
        }
        
    }
}
