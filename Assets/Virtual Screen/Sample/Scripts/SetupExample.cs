using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;

public class SetupExample : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Setup camera using "Resolution" - 384x216
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Resolution testResolution = new Resolution
            {
                width = 384,
                height = 216,
                refreshRate = 60
            };

            VirtualCamera.Instance.SetupCamera(testResolution);
        }

        // Setup camera using "int" - 320x180
        if (Input.GetKeyDown(KeyCode.X))
        {
            VirtualCamera.Instance.SetupCamera(320,180);
        }
    }
}
