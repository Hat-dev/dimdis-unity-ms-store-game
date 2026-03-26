using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class right3 : MonoBehaviour
{    
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Vector2 move;
    private bool moving = false;

    private void Update()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        if (moving)
        {
            Debug.Log("moving");
            rb.MovePosition(rb.position + move.normalized * moveSpeed * Time.fixedDeltaTime);
        }
    }

    public void OnButtonPress1()
    {
        // Called when the button is pressed
        moving = true;
        Debug.Log("pressed");
    }

    public void OnButtonRelease1()
    {
        // Called when the button is released
        moving = false;
    }
}
