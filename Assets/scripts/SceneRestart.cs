using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneRestart : MonoBehaviour
{

    [SerializeField]
    Pathmaker pathmaker;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) {
            Application.LoadLevel(Application.loadedLevel);
            pathmaker.Reset();
        }
    }
}
