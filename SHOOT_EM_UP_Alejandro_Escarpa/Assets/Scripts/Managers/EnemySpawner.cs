using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] enemies;
    public int enemiesCount;
    Vector2 spawnPos;
    bool canSpawnEnemies;


    private void Start()
    {
        canSpawnEnemies = true;
        spawnPos = transform.position;
        Invoke("SpawnEnemies", 0);
    }

    private void Update()
    {
        if(enemiesCount <= 0)
        {
            SpawnEnemies();
        }
    }

    private void SpawnEnemies()
    {
        if (canSpawnEnemies)
        {
            int randomEnemy = randomInt(0, enemies.Length);

            Instantiate(enemies[randomEnemy], spawnPos, Quaternion.identity, this.transform);
        }

        enemiesCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
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
