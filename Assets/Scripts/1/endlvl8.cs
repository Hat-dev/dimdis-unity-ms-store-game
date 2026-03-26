using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endlvl8 : MonoBehaviour
{
    public GameObject music;
    void Start()
    {   
        music = GameObject.FindWithTag("music");
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        completion.eightcomplete = true;
        Debug.Log("tru");
        Destroy(music);
        SceneManager.LoadScene("levelselect");
    }
}
