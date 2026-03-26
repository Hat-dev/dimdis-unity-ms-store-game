using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endlevel : MonoBehaviour
{
    public GameObject music;
    void Start()
    {
        music = GameObject.FindWithTag("music");
        Invoke("end", 60f);
    }

    void end()
    {
        Debug.Log("doen");
        completion.fourcomplete = true;
        Debug.Log("tru");
        Destroy(music);
        SceneManager.LoadScene("levelselect");
    }
}
