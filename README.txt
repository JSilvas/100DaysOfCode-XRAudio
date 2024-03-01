# Pseudo Code for Dynamic Audio System for Footsteps

## Core modules

### Player Controller -> 
    Audio output is routed to and played through the player Controller

### Sound class
    Csharp script defining an the sound object class with available properties to access when each sound is called

### Material Detector
    Detects which material a player is standing on

### Audio Manager
    Csharp script that contains logic for managing available audio and centrally organizing sound 
        - Plays specific set of randomized footstep sounds according to Material Detector
        - Define which footstep sets are available