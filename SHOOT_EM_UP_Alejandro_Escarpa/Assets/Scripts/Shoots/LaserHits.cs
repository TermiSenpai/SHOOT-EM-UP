using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserHits : MonoBehaviour
{
    [SerializeField] private ParticleSystem hitFbx;
    GameObject hitParent;
    private void Start()
    {
        hitParent = GameObject.FindGameObjectWithTag("HitsParent");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(hitFbx, collision.transform.position, Quaternion.identity, hitParent.transform);

        if (collision.collider.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
