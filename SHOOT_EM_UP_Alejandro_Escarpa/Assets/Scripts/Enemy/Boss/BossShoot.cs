using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShoot : MonoBehaviour
{
    [SerializeField] EnemyBossHp bossHP;
    [Space]
    [SerializeField] Transform[] lasersPos;
    [SerializeField] GameObject laserPrefab;

    [SerializeField] private float delay;

    private void Start()
    {
        InvokeRepeating("Shoot", 1, delay);
    }

    private void Shoot()
    {
        switch (bossHP.GetEnemyFase())
        {
            case 1:
                FirstFaseShoot();
                break;
            case 2:
                SecondFaseShoot();
                break;
            case 3:
                ThirdFaseShoot();
                break;
        }
    }

    private void FirstFaseShoot()
    {
        SpawnLasers(lasersPos[0]);
    }

    private void SecondFaseShoot()
    {
        for (int i = 1; i < lasersPos.Length; i++)
            SpawnLasers(lasersPos[i]);


    }

    private void ThirdFaseShoot()
    {
        foreach (Transform laserPos in lasersPos)
            SpawnLasers(laserPos);

    }

    private void SpawnLasers(Transform laserPos)
    {
        Instantiate(laserPrefab, laserPos.position, Quaternion.identity, laserPos);
    }


}
