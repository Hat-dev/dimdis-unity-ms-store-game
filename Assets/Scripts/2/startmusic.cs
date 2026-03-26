using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startmusic : MonoBehaviour
{
    public string scenename;
    [SerializeField] private GameObject select1Sound;
    void OnSceneLoaded(Scene scene, LoadSceneMode sceneMode)
    {
    // Plays different music in different scenes
        if (scene.name==scenename)
        {
            select1Sound.SetActive(true);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
