using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    private bool canShoot;

    [SerializeField] float delay;
    [SerializeField] GameObject laserPrefab;
    [SerializeField] Transform shootPos;

    private void Start()
    {
        canShoot = true;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && canShoot)
        {
            Instantiate(laserPrefab, shootPos.position, Quaternion.identity);
            StartCoroutine(ShootDelay());
        }
    }

    IEnumerator ShootDelay()
    {
        canShoot = false;
        yield return new WaitForSeconds(delay);
        canShoot = true;
    }
}
