using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private AudioMixer mixer;
    [SerializeField] private string mixerName;

    private void Start()
    {
        if (PlayerPrefs.HasKey(mixerName))
        {
            slider.value = PlayerPrefs.GetFloat(mixerName, 0.5f);
            setVolume(slider.value);
        }

    }

    public void setVolume(float sliderValue)
    {
        mixer.SetFloat(mixerName, Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat(mixerName, sliderValue);
    }
}
