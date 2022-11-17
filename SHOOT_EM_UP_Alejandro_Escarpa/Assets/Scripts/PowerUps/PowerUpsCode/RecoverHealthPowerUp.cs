using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecoverHealthPowerUp : PowerUp
{
    PlayerHealth playerhp;
    int healthRecover = 1;
    private void Start()
    {
        source = GameObject.FindGameObjectWithTag("PowerUpSpawner").GetComponent<AudioSource>();
        playerhp = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        source.PlayOneShot(audioClip);
        playerhp.RecoverHealth(healthRecover);
        Destroy(gameObject);
    }
}
