# Cannon Arms
A VR tower defense game in which one is defending the island they are on from incoming boats. The general concept circulates around the player having cannon arms and is defending their island/treasure chest from incoming ships. The game will have a score based system in which the players points will rise for each ship sunk. After a set amount of ships have been destroyed, the spawn rate and speed of the ships will increase.

Additional Information about development can be found here: http://web.cecs.pdx.edu/~reynx/_build/html/index.html

## Build instructions
To run the game one has to use an older version of Unity (2017.1.0), this is due to using the VRTK library as a new one is still in development and still lacks many of the tools used for this games development. Both VRTK and the SteamVR libraries are included in the build. 

### Prerequisites
* HTC Vive (HardWare)
* Unity 2017.1.0

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
  * Island and Trees
  * Test ones relative scale to island and trees, make it feel “right”
  * lighting

3. Implement ocean/water physics
  * Get boats to float (buoyancy)
  * Get boats to move toward an object (then move towards headset object)
  * End scene when a ship touches the island.

4.Cannon ball and boat interactions:
  * Delete boat on impact
  * Destroy boat into parts on impact, increase weight for segments to sink to ‘remove object’
  * Implement score for ship destruction.

5. Apply art and shaders:
  * Ocean Shader
  * ~~Sky box~~
  * Ocean, wind, cannon blast, and boat sound(for identification in terms of 360 audio to determine direction of incoming boat)

6. Scenes:
  * Game scene
  * Menu scene
  * High score list and update function for game finish

