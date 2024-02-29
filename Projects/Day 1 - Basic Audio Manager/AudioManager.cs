using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour {
    // Creates a public array 'sounds'
    public Sound[] sounds;
    
    public static AudioManager instance;

    // Use this for initilization
    void Awake () {
        
        // Ensures that there is only one instance of the AudioManager
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        // Loops through the array 'sounds' and adds an AudioSource to each sound.
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    void Start () {
        Play("Theme");
    }
    
    // Creates a public method 'Play' that takes a string 'name' as a parameter.
    public void Play (string name)
    {
        Sound s = Array.Find(sounds, sounds => sounds.name == name);
        if (s == null) {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.source.Play();
    }
    // FindObjectOfType<AudioManager>().Play("name"); can be called from any object script.
}