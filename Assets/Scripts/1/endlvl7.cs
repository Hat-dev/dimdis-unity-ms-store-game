using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endlvl7 : MonoBehaviour
{
    public GameObject music;
    void Start()
    {   
        Physics2D.IgnoreLayerCollision(7,9,true);
        music = GameObject.FindWithTag("music");
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        completion2.tencomplete = true;
        Debug.Log("tru");
        Destroy(music);
        SceneManager.LoadScene("levelselect 1");
    }
}
