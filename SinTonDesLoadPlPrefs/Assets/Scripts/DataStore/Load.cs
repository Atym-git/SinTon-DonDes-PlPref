using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Load : MonoBehaviour
{
    [SerializeField] private Slider[] volumeSliders;

    private List<string> volumeSlidersKeys = new();

    private const float startDelay = 1f;
    private void Start()
    {
        StartCoroutine(Delay());
        LoadKeys();
        LoadVolumeSliders();
    }

    private void LoadKeys()
    {
        for (int i = 0; i < Save.Instance.VolumeSlidersKeys.Count; i++)
        {
            volumeSlidersKeys[i] = PlayerPrefs.GetString($"Volume-{i}".ToLower());
        }
    }

    public void LoadVolumeSliders()
    {
        if (volumeSlidersKeys != null)
        {
            for (int i = 0; i < volumeSlidersKeys.Count; i++)
            {
                Debug.Log(volumeSlidersKeys[i]);
                volumeSliders[i].value = PlayerPrefs.GetFloat(volumeSlidersKeys[i]);
            }
        }
    }

    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(startDelay);
    }
}
