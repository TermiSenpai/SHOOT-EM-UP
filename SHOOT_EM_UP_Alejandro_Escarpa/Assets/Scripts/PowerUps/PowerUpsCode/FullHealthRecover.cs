using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class FullHealthRecover : PowerUp
{
    PlayerHealth playerhp;
    private void Start()
    {
        source = GameObject.FindGameObjectWithTag("PowerUpSpawner").GetComponent<AudioSource>();
        playerhp = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        source.PlayOneShot(audioClip);
        playerhp.RecoverFullHealth();
        Destroy(gameObject);
    }
}
