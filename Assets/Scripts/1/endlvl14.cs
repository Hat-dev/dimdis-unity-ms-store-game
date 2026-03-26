using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endlvl14 : MonoBehaviour
{
    public GameObject music;
    void Start()
    {   
        music = GameObject.FindWithTag("music");
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        completion2.fourteencomplete = true;
        Debug.Log("tru");
        Destroy(music);
        SceneManager.LoadScene("levelselect 1");
    }
}
