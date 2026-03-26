using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftbutton1 : MonoBehaviour
{
    public float rotationSpeed = 200f; // Adjust the rotation speed as needed

    public Rigidbody2D rb;
    private bool rotateCharacter = false;

    private void FixedUpdate()
    {
        if (rotateCharacter)
        {
            // Rotate the character while the button is held
            rb.angularVelocity = rotationSpeed * Time.deltaTime;
        }
    }

    public void OnButtonPress1()
    {
        // Called when the button is pressed
        rotateCharacter = true;
    }

    public void OnButtonRelease1()
    {
        // Called when the button is released
        rotateCharacter = false;
        rb.angularVelocity = 0f;
    }
}