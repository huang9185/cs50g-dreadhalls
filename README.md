# Dreadhalls - Procedural Maze Update 🏰

## Overview
A first-person horror maze game built entirely in Unity3D with custom C# scripting. The player must navigate a procedurally generated labyrinth filled with pitfalls and winding corridors to advance.

## Custom Features
* **Procedural Maze Generation:** Created a custom algorithm (`LevelGenerator.cs`) that uses a random crawler to dig out paths from a solid block of walls. 
* **Pitfalls:** The generator randomly punches holes in the floor (~10% chance). If the player falls through (`Y < -1`), a custom script (`DespawnOnHeight.cs`) resets progress and triggers a Game Over.
* **Level Progression Tracking:** Successfully grabbing a tagged pickup item plays an audio cue, increments the static Maze Counter (`DisplayMazeNumber.cs`), and seamlessly loads the next procedural level.
* **Persistent Audio Singleton:** Ensured the background audio persists across scene transitions without overlapping or duplicating using `DontDestroyOnLoad`.
