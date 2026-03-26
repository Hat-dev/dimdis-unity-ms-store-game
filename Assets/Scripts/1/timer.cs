using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    public float time=30;
    public healthbar hb;
    void Update()
    {
        if(time>10)
        {
            time-=Time.deltaTime;
        }
        hb.SetfloatHealth(time);
    }
}
