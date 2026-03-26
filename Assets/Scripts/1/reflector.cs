using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reflector : MonoBehaviour
{
    public Rigidbody2D rb;
    void OnTriggerEnter2D(Collider2D wal)
    {
        if (wal.gameObject.tag == "wall")
        {
            Debug.Log("reflekoffwall");
            transform.localScale = new Vector3(-rb.transform.localScale.x,1f,1f);        //reflects
            rb.velocity = new Vector2(-rb.velocity.x,0);
        }
    }
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("reflekoffdude");
            transform.localScale = new Vector3(-rb.transform.localScale.x,1f,1f);        //reflects
            rb.velocity = new Vector2(-rb.velocity.x,0);
        }
    }
    

}