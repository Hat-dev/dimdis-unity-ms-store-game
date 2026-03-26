using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomMove : MonoBehaviour
{
    int nextPos;
    public Transform[] positions;
    public float speed = 1000.0f;
    public float frequency=1;
    void Start()
    {
        nextPos = 0;
        InvokeRepeating("setPos", 0.0f, frequency);
    }
    void setPos()
    {
        nextPos = Random.Range(0,positions.Length);
    }
    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, positions[nextPos].position, speed*Time.deltaTime);
    }
}
