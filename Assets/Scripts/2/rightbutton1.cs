using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightbutton1 : MonoBehaviour
{
    public float rotationSpeed = 200f; // Adjust the rotation speed as needed

    public Rigidbody2D rb;
    private bool rotateCharacter2 = false;

    private void FixedUpdate()
    {
        if (rotateCharacter2)
        {
            // Rotate the character while the button is held
            float rotateAmount = rotationSpeed * Time.deltaTime;
            rb.angularVelocity = -rotateAmount;
        }
    }

    public void OnButtonPress1()
    {
        // Called when the button is pressed
        rotateCharacter2 = true;
    }

    public void OnButtonRelease1()
    {
        // Called when the button is released
        rotateCharacter2 = false;

        rb.angularVelocity = 0f;
    }
}
