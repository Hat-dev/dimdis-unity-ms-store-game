using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endlvl13 : MonoBehaviour
{
    public GameObject music;
    void Start()
    {   
        music = GameObject.FindWithTag("music");
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(music);
        completion.sevencomplete = true;
        Debug.Log("tru");
        SceneManager.LoadScene("levelselect");
    }
}
