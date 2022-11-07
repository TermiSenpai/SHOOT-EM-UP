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
        Instantiate(hitFbx, collision.GetContact(0).point, Quaternion.identity, hitParent.transform);

        Destroy(gameObject);
    }
}
