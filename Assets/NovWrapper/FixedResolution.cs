﻿using UnityEngine;

public class FixedResolution : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1280, 720, true);
    }
}
