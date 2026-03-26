using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pusher : MonoBehaviour
{
    [SerializeField] private AudioSource pushSound;
    void OnTriggerEnter2D (Collider2D other)
    {
        pushSound.Play();
        var magnitude = 2500;
        var force = transform.position - other.transform.position;
        force.Normalize ();
        GetComponent<Rigidbody2D> ().AddForce (force * magnitude);
    }
}