using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    private bool canShoot;

    [SerializeField] float delay;
    [SerializeField] GameObject laserPrefab;
    [SerializeField] Transform shootPos;

    GameObject laserParent;
    PlayerFbxPlayer sound;

    private void Start()
    {
        laserParent = GameObject.FindGameObjectWithTag("LaserParents");
        sound = GetComponent<PlayerFbxPlayer>();
        canShoot = true;

    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && canShoot)
        {
            sound.PlayShootSound();
            Instantiate(laserPrefab, shootPos.position, Quaternion.identity, laserParent.transform);
            StartCoroutine(ShootDelay(delay));
        }
    }

    IEnumerator ShootDelay(float delay)
    {
        canShoot = false;
        yield return new WaitForSeconds(delay);
        canShoot = true;
    }

    public bool GetCanShoot()
    {
        return canShoot;
    }

    public void SetCanShoot(bool value)
    {
        canShoot = value;
    }
}
