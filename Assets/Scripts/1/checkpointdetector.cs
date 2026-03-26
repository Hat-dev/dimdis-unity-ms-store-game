using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointdetector : MonoBehaviour
{
    private Vector3 respawnPoint;
    private Rigidbody2D rb;
    private Animator anim;
    public Rigidbody2D arrow2rb;
    public GameObject arrow1;
    public GameObject arrow2;
    public Vector3 arespawnpoint;
    public Vector3 arespawnpoint2;
    [SerializeField] private AudioSource deadSound;
    private void Start()
    {
        respawnPoint=transform.position;
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Nemeny"))
        {
            deadSound.Play();
            rb.bodyType = RigidbodyType2D.Static;
            Invoke("checkpoint",2f);
            Debug.Log ("died");
            anim.SetTrigger("death1");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Checkpoint")
        {
            respawnPoint=transform.position;
        }
    }
    public void checkpoint()
    {
        anim.SetTrigger("respawn");
        rb.bodyType = RigidbodyType2D.Dynamic;
        transform.position = respawnPoint;
        arrow1.transform.position = arespawnpoint;
        arrow2.transform.position = arespawnpoint2;
        arrow2rb.velocity = new Vector2(0, 0); 
    }
}
