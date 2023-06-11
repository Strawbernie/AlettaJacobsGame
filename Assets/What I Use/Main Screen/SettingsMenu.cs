using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public float volume;
    public void Start()
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void SetVolume (float volume)
    {
        //allows the player to set the volume with the slider in game
        audioMixer.SetFloat("volume", volume);
    }

    public void SetQuality(int qualityIndex)
    {
        //allows the player to choose the quality in the dropdown menu in game
        QualitySettings.SetQualityLevel(qualityIndex);
    }
}
