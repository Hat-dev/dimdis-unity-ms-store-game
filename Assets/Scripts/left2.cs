using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class left2 : MonoBehaviour
{
    public float thrust = 15.0f;
    public Rigidbody2D rb;
    public GameObject music;
    [SerializeField] private AudioSource swingSound;
    void Start()
    {
        music = GameObject.FindWithTag("music");
    }
    public void OnButtonClick()
    {
        swingSound.Play();
        rb.velocity = new Vector3(0,0,0);
        rb.AddForce (rb.transform.right*-50*thrust);
        rb.AddForce (rb.transform.up*50*thrust);
    } 
}
