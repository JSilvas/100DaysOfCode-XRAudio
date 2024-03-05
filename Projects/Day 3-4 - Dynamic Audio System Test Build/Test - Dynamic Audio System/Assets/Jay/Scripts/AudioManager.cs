using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    void Awake()
    {
        Debug.Log("AudioManager initialized");
        
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    // public void Play(string name)
    // {
    //     sounds s = Array.Find(sounds, sound => sound.name == name);
    //     s.source.Play();
    // }

    //====================================================================================================
    // Audio Helper Functions
    //====================================================================================================
    
    // function to player random audio clip from array
    
    // function to randomize volume of audio source
    
    // function to randomize pitch of audio source

    
    // ====================================================================================================
    // Audio Reporting
    // ====================================================================================================
    // function to report audio source status
    // {
    //     action: jump,
    //     surface: snow,
    //     pitch: 1.1,
    //     gain: 0.9,
    // }

}
