using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deletemusic : MonoBehaviour
{
    void Update()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
