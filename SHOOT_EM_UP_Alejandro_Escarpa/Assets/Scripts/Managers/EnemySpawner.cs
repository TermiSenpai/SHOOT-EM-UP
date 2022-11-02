using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] enemies;
    [SerializeField] float delay;
    

    private void Start()
    {
        InvokeRepeating("SpawnEnemies", delay, delay);
    }

    private void SpawnEnemies()
    {
        int randomEnemy = randomInt(0, enemies.Length);
        Vector2 spawnPos = new Vector2(15, 0);

        Instantiate(enemies[randomEnemy], spawnPos, Quaternion.identity);
    }



    private float randomFloat(float min, float max)
    {
        return Random.Range(min, max);
    }

    private int randomInt(int min, int max)
    {
        return Random.Range(min, max);
    }
}
