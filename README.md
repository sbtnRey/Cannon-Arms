# Cannon Arms
Copyright &copy; 2018 Sebastian Reynolds

A VR Shoot 'Em Up game in which one is defending their island from incoming ships with cannon arms. The game will have a score based system in which the players points will rise for each ship sunk. After a set amount of ships have been destroyed, the spawn rate and speed of the ships will increase. If a ship reaches the island it is GAME OVER.


## Build instructions
To run the game one has to use an older version of Unity (2017.1.0), this is due to using the VRTK library as a new one is still in development and still lacks many of the tools used for this games development. One also needs to download VRTK Library, the SteamVR plugin (The Unity asset store is the easiest way to do download them), and the unity water buoyancy library and place all libraries in the assets folder.

### Prerequisites
* HTC Vive (HardWare)
* [Unity 2017.1.0](https://unity3d.com/unity/whats-new/unity-2017.1.0)
* [SteamVR Plugin](https://assetstore.unity.com/packages/templates/systems/steamvr-plugin-32647)
* [VRTK](https://assetstore.unity.com/packages/tools/vrtk-virtual-reality-toolkit-vr-toolkit-64131)
* [Buoyancy Library](https://github.com/dbrizov/Unity-WaterBuoyancy)

## Author

**Sebastian Reynolds**

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details


## Goals/Check List
1. Core Mechanics
  * ~~Cannons shoot cannon balls and interact with objects~~
  * ~~Implement cannon ball physics~~
  * ~~Create VR environment~~
  
    [Progress clip 0](https://media.giphy.com/media/LUQ6WC0pFwB7213LWJ/giphy.gif)

2. Environment
  * ~~Island and Trees~~
  * ~~Test ones relative scale to island and trees, make it feel “right”~~
  * ~~lighting~~
  
    [Progress clip 1](https://media.giphy.com/media/3mjR4BAyhk8Z5Vmcfo/giphy.gif)

3. Implement ocean/water physics
  * ~~Get boats to float (buoyancy)~~
  * ~~Get boats to move toward an object (then move towards headset object)~~
  * ~~End scene when a ship touches the island.~~

4.Cannon ball and boat interactions:
  * ~~Delete boat on cannon ball impact~~
  * ~~Destroy boat into parts on impact, increase weight for segments to sink to ‘remove object’~~
  * ~~Implement score for ship destruction.~~

5. Apply art and shaders:
  * ~~Ocean Shader~~
  * ~~Sky box~~
  * Ocean, wind, cannon blast, and boat sound(for identification in terms of 360 audio to determine direction of incoming boat)

6. Scenes:
  * Game scene
  * Menu scene
  * High score list and update function for game finish
  
[Gameplay of current state](https://www.youtube.com/watch?v=X-YDfyDWEmE)

