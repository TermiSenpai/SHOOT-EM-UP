using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] private Transform laserSpawnPos;
    [SerializeField] private GameObject laserPrefab;
    private GameObject laserParent;
    [Space]
    [SerializeField] float delay;

    // Start is called before the first frame update
    void Start()
    {
        laserParent = GameObject.FindGameObjectWithTag("LaserParents");
        InvokeRepeating("SpawnShoot", delay, delay);
    }


    private void SpawnShoot()
    {
        Instantiate(laserPrefab, laserSpawnPos.position, Quaternion.identity, laserParent.transform);
    }
}
