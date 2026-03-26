using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowmove : MonoBehaviour
{
    public float arrowSpeed;
    public Rigidbody2D rb;
    void Start()
    {
        Physics2D.IgnoreLayerCollision(3,9,true);
        rb.velocity = new Vector2(arrowSpeed, 0);
    }


    void Update()
    {
        
    }
}
