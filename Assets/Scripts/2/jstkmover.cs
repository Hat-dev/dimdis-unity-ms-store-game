using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class jstkmover : MonoBehaviour
{
    private RectTransform joystickTransform;
    private Vector2 inputDirection;
    public newcmove characterController; // Reference to the CreativeMove script
    public GameObject movementArea; // Reference to the GameObject representing the movement area

    private bool isJoystickActive = false;
    private float movementRadius;

    private void Start()
    {
        joystickTransform = GetComponent<RectTransform>();
        movementRadius = movementArea.GetComponent<RectTransform>().rect.width / 2f;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 position;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(joystickTransform, eventData.position, eventData.pressEventCamera, out position))
        {
            Vector2 localPosition = position - joystickTransform.sizeDelta / 2f;
            inputDirection = localPosition.normalized;

            // Clamp the joystick handle within the movement area
            if (localPosition.magnitude > movementRadius)
            {
                inputDirection = localPosition.normalized * movementRadius;
            }

            // Send joystick input to the character controller script
            characterController.SetJoystickInput(inputDirection);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isJoystickActive = true;
        OnDrag(eventData);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isJoystickActive = false;
        inputDirection = Vector2.zero;

        // Send zero input to the character controller script to stop movement
        characterController.SetJoystickInput(inputDirection);
    }
}
