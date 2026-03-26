using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activator : MonoBehaviour
{
    public GameObject[] wave2;
    public int batamount = 12;
    public GameObject endport;
    public Transform endportalpos;
    public GameObject music;
    public void Awake()
    {
        wave2[0].SetActive(false);
        wave2[1].SetActive(false);
        wave2[2].SetActive(false);
        wave2[3].SetActive(false);
        wave2[4].SetActive(false);
    }
    void Start()
    {
        Invoke("act",10f);
    }
    void Update()
    {
        if (batamount==2)
        {
            batamount= batamount+1;
            Instantiate (endport, endportalpos.position, Quaternion.identity);
            Destroy(music);
        }
    }

    void act()
    {
        wave2[0].SetActive(true);
        wave2[1].SetActive(true);
        wave2[2].SetActive(true);
        wave2[3].SetActive(true);
        wave2[4].SetActive(true);
    }
}
