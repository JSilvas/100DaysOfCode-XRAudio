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
    private void randomizePitch(AudioSource audioSource, float pitchRange)
    {
        float sourcePitch = audioSource.pitch;
        float randomPitch = Random.Range(sourcePitch - pitchRange, sourcePitch + pitchRange);
        audioSource.pitch = randomPitch;
    }
}
