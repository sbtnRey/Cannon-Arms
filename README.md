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

1a. Cannons shoot cannon balls and interact with objects
1b. Implement cannon ball physics (drop and charge)
Create VR environment

2a. Island and Trees
2b. Test ones relative scale to island and trees, make it feel “right”
2c. lighting
Implement ocean/water physics

3a. Get boats to float (buoyancy)
3b. Get boats to move toward an object (then move towards headset object)
3c. End scene when a ship touches the island.
Cannon ball and boat interactions:

4a. Delete boat on impact
4b. Destroy boat into parts on impact, increase weight for segments to sink to ‘remove object’
4a. Implement score for ship destruction.
Apply art and shaders:

5a. Ocean Shader
5b. Sky box
5c. Ocean, wind, cannon blast, and boat sound(for identification in terms of 360 audio to determine direction of incoming boat)
Scenes:

6a. Game scene
6b. Menu scene
6c. High score list and update function for game finish

