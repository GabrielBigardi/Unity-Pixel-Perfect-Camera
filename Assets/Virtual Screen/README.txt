=======================
INSTALLATION
1 - Delete your camera to avoid conflicts.
2 - Import the asset
3 - Go into "Prefabs" folder, drag and drop "Main Camera" prefab into your scene.
=======================

=======================
SCRIPTING REFERENCE:
VirtualCamera.Instance.SetupCamera(Resolution resolution);
VirtualCamera.Instance.SetupCamera(int weight, int height);

You can use any of these methods to setup your camera.
The first method uses a Resolution object to setup it.
The second method uses two int's to setup it.

Sample code - First Method:
Resolution testResolution = new Resolution { width = 320, height = 180, refreshRate = 60};
VirtualCamera.Instance.SetupCamera(testResolution);

Sample Code - Second Method:
VirtualCamera.Instance.SetupCamera(320, 180);
=======================