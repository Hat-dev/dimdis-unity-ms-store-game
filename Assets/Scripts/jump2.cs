using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jump2 : MonoBehaviour
{
    public float thrust = 150.0f;
    public Rigidbody2D dude;
    [SerializeField] private AudioSource clapSound;
    public void OnButtonClick()
    {
            clapSound.Play();
            dude.velocity = new Vector3(0,0,0);
            dude.AddForce (dude.transform.up*thrust);
    }
}
