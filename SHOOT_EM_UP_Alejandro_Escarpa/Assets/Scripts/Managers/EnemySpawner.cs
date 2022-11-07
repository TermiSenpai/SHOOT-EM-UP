using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] enemies;
    [SerializeField] float delay;
    

    private void Start()
    {
        InvokeRepeating("SpawnEnemies", 0, delay);
    }

    private void SpawnEnemies()
    {
        int randomEnemy = randomInt(0, enemies.Length);
        Vector2 spawnPos = new Vector2(10, 0);

        Instantiate(enemies[randomEnemy], spawnPos, Quaternion.identity, this.transform);
    }

    private int randomInt(int min, int max)
    {
        return Random.Range(min, max);
    }
}
