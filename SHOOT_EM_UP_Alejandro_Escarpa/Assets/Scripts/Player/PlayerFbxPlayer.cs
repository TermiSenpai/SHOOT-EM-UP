using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFbxPlayer : MonoBehaviour
{
    [SerializeField] AudioSource source;
    [SerializeField] AudioClip clip;

    public void PlayShootSound()
    {
        source.PlayOneShot(clip);
    }
}
