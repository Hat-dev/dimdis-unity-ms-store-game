using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateslow : MonoBehaviour
{
    public float offset = 0f;
    public float sbeed = 0.01f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
    difference.Normalize();
    float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
    Quaternion rotateTo = Quaternion.Euler(0f, 0f, rotation_z + offset);
    transform.rotation = Quaternion.Lerp(transform.rotation, rotateTo, sbeed);
    }
}
