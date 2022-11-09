using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserHits : MonoBehaviour
{
    [SerializeField] private ParticleSystem hitFbx;
    FXPlayer fxPlayer;
    private void Start()
    {
        fxPlayer = GameObject.FindGameObjectWithTag("HitsParent").GetComponent<FXPlayer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        fxPlayer.InstantiateParticleFx(hitFbx, collision.GetContact(0).point);

        Destroy(gameObject);
    }
}
