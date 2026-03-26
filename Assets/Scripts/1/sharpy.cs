using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sharpy : MonoBehaviour
{
    public float sbeed;
    public GameObject dude;

    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, dude.transform.position, sbeed*Time.deltaTime);
    }
    void Collision2D(Collider2D collision)
    {
        
    }
}

