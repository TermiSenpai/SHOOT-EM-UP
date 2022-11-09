using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserHits : MonoBehaviour
{
    [SerializeField] private ParticleSystem hitFbx;
    FXPlayer fxPlayer;

    GameManager manager;
    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        fxPlayer = GameObject.FindGameObjectWithTag("HitsParent").GetComponent<FXPlayer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            manager.IncreasePoints(100);
        }
        else if (collision.collider.CompareTag("Laser"))
        {
            manager.IncreasePoints(10);
        }

        fxPlayer.InstantiateParticleFx(hitFbx, collision.GetContact(0).point);

        Destroy(gameObject);
    }
}
