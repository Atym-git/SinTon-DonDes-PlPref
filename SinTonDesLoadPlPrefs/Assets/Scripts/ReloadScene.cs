using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
    [SerializeField] private KeyCode _reloadKeyCode = KeyCode.R;
    void FixedUpdate()
    {
        if (Input.GetKeyDown(_reloadKeyCode))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
