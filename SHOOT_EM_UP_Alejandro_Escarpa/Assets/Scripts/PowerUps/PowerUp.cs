using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public AudioClip audioClip;

    public AudioSource source;

    private void Start()
    {
        source = GameObject.FindGameObjectWithTag("PowerUpSpawner").GetComponent<AudioSource>();
    }
}
