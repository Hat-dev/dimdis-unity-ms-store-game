using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endlvl2 : MonoBehaviour
{
    public GameObject music;
    void Start()
    {   
        music = GameObject.FindWithTag("music");
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        completion.twocomplete = true;
        Debug.Log("tru");
        Destroy(music);
        SceneManager.LoadScene("levelselect");
    }
}
