using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] enemies;
    [SerializeField] float delay;
    Vector2 spawnPos;
    bool canSpawnEnemies;


    private void Start()
    {
        canSpawnEnemies = true;
        spawnPos = transform.position;
        InvokeRepeating("SpawnEnemies", 0, delay);
    }

    private void SpawnEnemies()
    {
        if (canSpawnEnemies)
        {
            int randomEnemy = randomInt(0, enemies.Length);

            Instantiate(enemies[randomEnemy], spawnPos, Quaternion.identity, this.transform);
        }
    }

    private int randomInt(int min, int max)
    {
        return Random.Range(min, max);
    }

    public bool getCanSpawnEnemies()
    {
        return canSpawnEnemies;
    }

    public void SetCanSpawnEnemies(bool value) => canSpawnEnemies = value;
}
