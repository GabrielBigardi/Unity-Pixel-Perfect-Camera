using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualCamera : MonoBehaviour
{
    public static VirtualCamera Instance;

    [Header("Hierarchy Stuff")]
    public Camera mainCamera;
    public Camera virtualCamera;
    public Transform virtualScreenQuad;

    [Header("Assets Stuff")]
    public RenderTexture renderTexture;

    /// <summary>
    /// Singleton initialization
    /// </summary>
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else if (Instance != this)
            Destroy(gameObject);
    }

    /// <summary>
    /// Setup camera by using a Resolution object
    /// </summary>
    /// <param name="resolution"></param>
    public void SetupCamera(Resolution resolution)
    {
        mainCamera.orthographicSize = resolution.height / 2;
        virtualCamera.orthographicSize = resolution.height / 2;
        virtualScreenQuad.localScale = new Vector3(resolution.width, resolution.height, 1f);
        renderTexture.Release();
        renderTexture.antiAliasing = 1;
        renderTexture.filterMode = FilterMode.Point;
        renderTexture.width = resolution.width;
        renderTexture.height = resolution.height;
        renderTexture.Create();
    }

    /// <summary>
    /// Setup camera by using width and height
    /// </summary>
    /// <param name="width"></param>
    /// <param name="height"></param>
    public void SetupCamera(int width, int height)
    {
        mainCamera.orthographicSize = height / 2;
        virtualCamera.orthographicSize = height / 2;
        virtualScreenQuad.localScale = new Vector3(width, height, 1f);
        renderTexture.Release();
        renderTexture.antiAliasing = 1;
        renderTexture.filterMode = FilterMode.Point;
        renderTexture.width = width;
        renderTexture.height = height;
        renderTexture.Create();
    }
}
