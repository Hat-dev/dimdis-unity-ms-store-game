using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backgroundmusic : MonoBehaviour
{
    static backgroundmusic instance;
 
     // Drag in the .mp3 files here, in the editor
    public AudioClip[] MusicClips;
 
    public AudioSource Audio;
 
     // Singelton to keep instance alive through all scenes
    void Awake()
    {
        if (instance == null) { instance = this; }
        else { Destroy(gameObject); }
 
        DontDestroyOnLoad(gameObject);
 
        // Hooks up the 'OnSceneLoaded' method to the sceneLoaded event
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // Called whenever a scene is loaded
    void OnSceneLoaded(Scene scene, LoadSceneMode sceneMode)
    {
          // Plays different music in different scenes
        switch (scene.name)
        {
            case "1DottedLine":
                Audio.clip = MusicClips[0];
                break;
            case "2PolkaDots":
                Audio.clip = MusicClips[1];
                break;
            default:
                Audio.clip = MusicClips[2];
                break;
        }
    }
}
