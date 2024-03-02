using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Footstep Collection", menuName = "Create New Footstep Collection")]

public class FootstepCollection : ScriptableObject
{
    public List<AudioClip> footstepSounds = new List<AudioClip>();
    // public List<AudioClip> jumpSounds = new List<AudioClip>();
    public List<AudioClip> landSounds = new List<AudioClip>();
    // public List<AudioClip> fallSounds = new List<AudioClip>();
    // public List<AudioClip> hurtSounds = new List<AudioClip>();
    // public List<AudioClip> deathSounds = new List<AudioClip>();
    // public List<AudioClip> attackSounds = new List<AudioClip>();
    // public List<AudioClip> dashSounds = new List<AudioClip>();
}
