using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newrotate : MonoBehaviour
{
    public float rotationSpeed = 100f;
    public float offsetAngle = 0f; // The offset angle for rotation
    private Vector2 rotationInput;
    private float currentRotationAngle; // The current rotation angle

    void Update()
    {
        RotateObject();
    }

    public void SetRotationInput(Vector2 input)
    {
        rotationInput = input;
    }

    public void SetOffsetAngle(float angle)
    {
        offsetAngle = angle;
    }

    private void RotateObject()
    {
        if (rotationInput.magnitude > 0.1f)
        {
            // Calculate the rotation angle based on the joystick input and offset angle
            float angle = Mathf.Atan2(rotationInput.y, rotationInput.x) * Mathf.Rad2Deg + offsetAngle;

            // Apply the rotation to the target GameObject
            transform.rotation = Quaternion.Euler(0f, 0f, angle);

            // Update the current rotation angle
            currentRotationAngle = angle;
        }
    }
}