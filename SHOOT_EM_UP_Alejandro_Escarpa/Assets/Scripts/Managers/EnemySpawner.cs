using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] enemies;
    [SerializeField] private GameObject boss;
    public int enemiesCount = 0;
    Vector2 spawnPos;
    bool canSpawnEnemies;

    public int round = 1;


    private void Start()
    {
        canSpawnEnemies = true;
        spawnPos = transform.position;
    }

    private void Update()
    {
        if(enemiesCount <= 0)
        {
            round++;
            SpawnEnemies();
        }
    }

    private void SpawnEnemies()
    {
        if (canSpawnEnemies)
        {
            int randomEnemy = randomInt(0, enemies.Length);

            Instantiate(enemies[randomEnemy], spawnPos, Quaternion.identity, transform);
        }

        float boosRound = round % 15;

        if(canSpawnEnemies && boosRound == 0 )
        {
            Instantiate(boss, spawnPos, Quaternion.Euler(0,0,-90), transform);
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
