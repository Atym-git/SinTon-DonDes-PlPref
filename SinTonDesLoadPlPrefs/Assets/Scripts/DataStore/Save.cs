using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Save : MonoBehaviour
{
    public static Save Instance { get; private set; }

    public List<string> VolumeSlidersKeys { get; private set; } = new List<string>();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void PlPrefsSave(string key, float value)
    {
        PlayerPrefs.SetFloat(key, value);
        if (!VolumeSlidersKeys.Contains(key))
        {
            VolumeSlidersKeys.Add(key);
        }
        SaveKeys();
    }

    private void SaveKeys()
    {
        for (int i = 0; i < VolumeSlidersKeys.Count; i++)
        {
            PlayerPrefs.SetString($"Volume-{i}".ToLower(), VolumeSlidersKeys[i]);
        }
    }
}
