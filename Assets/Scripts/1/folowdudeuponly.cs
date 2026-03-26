using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class folowdudeuponly : MonoBehaviour
{
    public float updisposition;
    public float sbeed = 0.3f;
    public Transform player;
    void Start()
    {
        transform.position = new Vector3 (0, player.position.y+updisposition, -10);
    }

    // Update is called once per frame
    void FixedUpdate () 
    {
        Vector3 bigposition = new Vector3 (0, player.position.y+updisposition, -10);
        transform.position = Vector3.Lerp(transform.position, bigposition, sbeed);
    }
}
