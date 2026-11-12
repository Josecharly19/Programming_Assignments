# Programming Assignments

A student Unity project containing programming exercises and prototypes. The current repository includes a small item pickup and inventory prototype alongside a camera manager.

## Implemented features

- Item definitions use Unity `ScriptableObject` assets with a name, icon, and size fields.
- A player pickup script detects an item in a trigger and picks it up when **E** is pressed.
- Picked up items are added to a simple inventory manager; the scene object is then removed.
- An inventory UI can be toggled with **I** and pauses the game while open.
- The inventory UI creates 60 visual slots and displays item icons.
- A camera manager script can activate a selected camera.

These are code-level features present in the repository. Their scene setup and behavior have not been independently tested.

## Technologies

- Unity **6000.2.10f1** (version recorded in `ProjectSettings/ProjectVersion.txt`)
- C#
- Unity Input System package and Universal Render Pipeline (listed in `Packages/manifest.json`)

## Open the project

1. Install Unity Hub and the Unity Editor version **6000.2.10f1**.
2. Clone or download this repository.
3. In Unity Hub, choose **Add** / **Add project from disk** and select the repository folder.
4. Open the project and let Unity import its assets and packages.
5. Open `Assets/Scenes/SampleScene.unity` from the Project window, then press **Play**.

The scene and scripts may rely on Inspector references and collider/UI setup. If the scene does not run as expected, inspect those references in the Unity Editor.

## Status and limitations

This is a learning project, not a finished or released game. The repository contains a sample scene and prototype scripts; it does not include a packaged playable build or detailed user documentation. Some functionality may require additional scene configuration, and the project has not been verified here in Play mode.

## Learning project

This repository is shared as a record of student practice with Unity and C#. It should be treated as a prototype and may change as the exercises develop.
