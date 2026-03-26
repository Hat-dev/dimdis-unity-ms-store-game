using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endlvl11 : MonoBehaviour
{
    public GameObject music;
    void Start()
    {   
        music = GameObject.FindWithTag("music");
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        completion2.elevencomplete = true;
        Destroy(music);
        Debug.Log("tru");
        SceneManager.LoadScene("levelselect 1");
    }
}
