﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SeamlessAudio : MonoBehaviour
{

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        if (objs.Length > 1)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);

    }
}