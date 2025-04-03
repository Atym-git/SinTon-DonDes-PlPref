using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;

public class SourceProperties : MonoBehaviour
{
    public static SourceProperties Instance {  get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }
}
