using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowmoveonimpact : MonoBehaviour
{
    public float arrowSpeed;
    public Rigidbody2D rb;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Physics2D.IgnoreLayerCollision(3,9,true);
        rb.velocity = new Vector2(arrowSpeed, 0); 
    }
}
