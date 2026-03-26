using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class jstkcontroller : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    private RectTransform joystickTransform;
    private Vector2 inputDirection;

    public float joystickRadius;
    public newcmove characterController; // Reference to the CreativeMove script

    public RectTransform joystickBackground;


    private void Start()
    {
        joystickTransform = GetComponent<RectTransform>();
        joystickRadius = joystickBackground.sizeDelta.x * 0.5f;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 localPoint;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(joystickBackground, eventData.position, eventData.pressEventCamera, out localPoint))
        {
            Vector2 clampedPosition = new Vector2(
                Mathf.Clamp(localPoint.x, -joystickRadius, joystickRadius),
                Mathf.Clamp(localPoint.y, -joystickRadius, joystickRadius)
            );

            joystickTransform.localPosition = clampedPosition;
        }
        Vector2 position;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(joystickTransform, eventData.position, eventData.pressEventCamera, out position))
        {
            position.x = (position.x / joystickTransform.sizeDelta.x);
            position.y = (position.y / joystickTransform.sizeDelta.y);

            float x = (joystickTransform.pivot.x == 1f) ? position.x * 2 + 1 : position.x * 2 - 1;
            float y = (joystickTransform.pivot.y == 1f) ? position.y * 2 + 1 : position.y * 2 - 1;

            inputDirection = new Vector2(x, y);
            inputDirection = (inputDirection.magnitude > 1) ? inputDirection.normalized : inputDirection;

            // Send joystick input to the character controller script
            characterController.SetJoystickInput(inputDirection);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        OnDrag(eventData);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        inputDirection = Vector2.zero;

        // Send zero input to the character controller script to stop movement
        characterController.SetJoystickInput(inputDirection);
    }
}

