using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetSoundVolume : MonoBehaviour
{
    [SerializeField] private AudioMixer mainMixer;

    private const string masterVolume = "MasterVolume";

    public void SetMainVolume(float sliderValue)
    {
        mainMixer.SetFloat(masterVolume, Mathf.Log10(sliderValue) * 20f);
        Save.Instance.PlPrefsSave(masterVolume, Mathf.Log10(sliderValue) * 20f);
    }
}
