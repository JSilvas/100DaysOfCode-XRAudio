using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("AudioManager initialized");
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    //====================================================================================================
    // Audio Helper Functions
    //====================================================================================================
    public void randomizePitch(AudioSource audioSource, float pitchRange)
    {
        float sourcePitch = audioSource.pitch;
        float randomPitch = Random.Range(sourcePitch - pitchRange, sourcePitch + pitchRange);
        audioSource.pitch = randomPitch;
    }

    public void randomizeVolume(AudioSource audioSource, float volumeRange)
    {
        float sourceVolume = audioSource.volume;
        float randomVolume = Random.Range(sourceVolume - volumeRange, sourceVolume + volumeRange);
        audioSource.volume = randomVolume;
    }

    public void playRandomSound(AudioSource audioSource, AudioClip[] audioClips)
    {
        audioSource.clip = audioClips[Random.Range(0, audioClips.Length)];
        audioSource.Play();
    }
}
