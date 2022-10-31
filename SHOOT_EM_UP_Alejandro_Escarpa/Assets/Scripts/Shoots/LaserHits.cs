using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserHits : MonoBehaviour
{
    [SerializeField] private ParticleSystem hitFbx;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(hitFbx, collision.transform);

        if (collision.collider.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
