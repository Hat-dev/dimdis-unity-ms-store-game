using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump1 : MonoBehaviour
{
    [SerializeField] private float forwardForce = 17f;
    public Rigidbody2D dude;
    public GameObject music;
    [SerializeField] private AudioSource jumpSound;
    void Start()
    {
        music = GameObject.FindWithTag("music");
    }
    public void OnButtonClick()
    {
            jumpSound.Play();
            dude.velocity = new Vector3(0,0,0);
        dude.AddForce (dude.transform.up*forwardForce);
    }
}
