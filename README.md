# CS455 Module 2 PR1.2: NavMeshes++  
Author: Georgiy Antonovich Bondar  

Go to https://keshakot.github.io/CS455_M2.PR1.2/ to play the game)

# Behaviors
Player Movement: Assets/Scripts/PlayerMovement.cs  
Level generation: Assets/Scripts/LevelGenerator.cs
Obstacle Movement: Assets/Scripts/ObstacleOscillation.cs
NavMesh Components: Assets/NavMeshComponents/  

# Modifications
1. Added links between NavMeshes (the four platforms)
2. Added obstacle avoidance to the player - the NavMesh updates with obstacle movement.
3. Added level auto-generation for the left two platforms.  

# Notes, Issues, Bugs
1. Level generation and obstacle movement were adapted from the examples found here: https://github.com/Brackeys/NavMesh-Tutorial   
2. When the player arrives, it will not move unless prompted by another click. This means that if it stops in the path of an obstacle, it will let the obstacle hit it and will not move away, as may be desired.   
3. The player will take links even if they go through objects on the other end. With static objects, such as those on the platform on which the player spawns, this can be avoided by forming links accordingly. On the auto-generated platforms on the left, this cannot be so.  

