using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingRotator : MonoBehaviour
{
    public float rotationspeed=50;
    [SerializeField] private float swapDownTime = 10f;
    private float swapTimer;
    void Update()
    {
        swapTimer += Time.deltaTime;
        while (swapTimer > swapDownTime)
        {
            swapTimer = 0f;
            Swap();
        }
    }
    void FixedUpdate()
    {
        transform.Rotate (0,0,rotationspeed*Time.deltaTime);
    }
    void Swap()
    {
        rotationspeed=-1*rotationspeed;
    }
}
