# Abstract for Dynamic Audio System for Footsteps

## Core modules

### Player Controller -> 
    Footstep audio triggers from animations

### Surface Detector
    Detects which material a player is standing on




### Audio Manager
    Csharp script that contains logic for managing available audio and centrally organizing sound 
        - Plays specific set of randomized footstep sounds according to Material Detector
        - Define which footstep sets are available

### Sound class
    Csharp script defining an the sound object class with available properties