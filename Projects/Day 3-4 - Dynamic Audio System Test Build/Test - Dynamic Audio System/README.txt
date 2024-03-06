## Requirements to Run Project

- Unity 2022.3.20f1


To ease consolidation of my work, all of the added scripts, terrain, and sound assets are currently contained within the Assets/Jay folder.



# Current Implementation

## Initial Component-based Approach

### Player Controller →

The central control-point is anchored to the `ThirdPersonController [modified].cs` component on the Player Armature.
A `CheckLayers` function assesses if the current surface has changed for each call of `OnFootstep` and `OnLand`. `SwapFootsteps` then changes out the footstep collection audio clips are fired from.

There are a few other scripts initially created to isolate different components of the solution.

### Surface Detection →

The Script `FootstepSwapper.cs` provides a function `CheckLayers` which detects surface a player is standing on via raycast hit report and uses conditional logic to call `swapFootsteps` to switch sound collections.

### Terrain Check →

The `TerrainChecker.cs` script returns the primary terrain from the current mix of terrain layers

### Sound Collections →

`FootstepCollection.cs` class for easily creating new curated sound clip sets assignable to each terrain or `SurfaceType`

### Assignable Surface Types →

`SurfaceType.cs` enables assignment of a footstep sound collection to specific game objects, to cover other non terrain-based objects