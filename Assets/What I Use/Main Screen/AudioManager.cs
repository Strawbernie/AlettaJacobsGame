using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public Slider volumeSlider;
    public Slider synchronizationSlider;

    private void Start()
    {
        // Add listeners to the volume slider
        volumeSlider.onValueChanged.AddListener(OnVolumeSliderValueChanged);
        synchronizationSlider.onValueChanged.AddListener(OnSynchronizationSliderValueChanged);
    }

    private void OnVolumeSliderValueChanged(float value)
    {
        // Update the volume when the volume slider is changed
        float volumeValue = volumeSlider.value;
        Debug.Log("Volume: " + volumeValue);

        // Synchronize the other slider to the same value
        synchronizationSlider.value = volumeValue;
    }

    private void OnSynchronizationSliderValueChanged(float value)
    {
        // Update the volume when the synchronization slider is changed
        float synchronizationValue = synchronizationSlider.value;
        Debug.Log("Synchronization: " + synchronizationValue);

        // Update the volume slider to the same value
        volumeSlider.value = synchronizationValue;
    }
}
