using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public Slider volumeSlider;
    public Slider SynchSlider;
    public AudioMixer Mixer;
    private float value;
    private void Start()
    {
        Mixer.GetFloat("volume", out value);
        volumeSlider.value = value;
        SynchSlider.value = value;
    }
    public void SetVolume (float volume)
    {
        Mixer.SetFloat("volume", volumeSlider.value);
        SynchSlider.value = volumeSlider.value;
    }
    public void SetQuality(int qualityIndex)
    {
        //allows the player to choose the quality in the dropdown menu in game
        QualitySettings.SetQualityLevel(qualityIndex);
    }
}
