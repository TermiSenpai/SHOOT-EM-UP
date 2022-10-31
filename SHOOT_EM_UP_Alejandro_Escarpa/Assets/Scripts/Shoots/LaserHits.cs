using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserHits : MonoBehaviour
{
    [SerializeField] private ParticleSystem hitFbx;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            Debug.Log("Hit");
            Instantiate(hitFbx, collision.transform);
            Destroy(gameObject);
        }
    }
}
