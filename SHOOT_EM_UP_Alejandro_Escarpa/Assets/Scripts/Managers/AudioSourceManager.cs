using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioSourceManager : MonoBehaviour
{
    AudioSource[] sources;
    [SerializeField] AudioMixerGroup mixer;

    private void Awake()
    {
       sources = FindObjectsOfType<AudioSource>();

        foreach( AudioSource source in sources)
        {
            source.outputAudioMixerGroup = mixer;
        }
    }
}
