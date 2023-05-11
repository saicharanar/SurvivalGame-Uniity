using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private List<Transform> SpawnPoints;
    [SerializeField] private GameObject EnemyPrefab;
    [SerializeField] private float TimeBetweenSpawn = 4f;
    private float _timeStamp = 0f;
    
    void FixedUpdate()
    {
        if(Time.time >= _timeStamp)
        {
            SpawnEnemy();
            _timeStamp = Time.time + TimeBetweenSpawn;
        }
        
    }

    private void SpawnEnemy()
    {
        SpawnPoints.ForEach((SpawnPoint =>
        {
            Instantiate(EnemyPrefab, SpawnPoint.position, Quaternion.identity);
        } ));
    }
}
