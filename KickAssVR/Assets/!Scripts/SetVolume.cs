﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider slider;

    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("MusicVolume", 0.75f);
    }

    public void SetLevel()
    {
        float sliderValue = slider.value;
        mixer.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 40);
        PlayerPrefs.SetFloat("MusicVolume", sliderValue);
    }
}