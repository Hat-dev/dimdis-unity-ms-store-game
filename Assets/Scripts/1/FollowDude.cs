using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowDude : MonoBehaviour
{
    public float updisposition;
    public float rightdisposition;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3 (player.position.x+rightdisposition, player.position.y+updisposition, -10);
    }

    // Update is called once per frame
    void FixedUpdate () 
    {
        transform.position = new Vector3 (player.position.x+rightdisposition, player.position.y+updisposition, -10);
    }
}
