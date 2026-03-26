using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class powcontroler : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{

    private RectTransform joystickTransform;
    private Vector2 rotationInput;

    public float joystickRadius;
    public newrotate rotationController; // Reference to the RotationController script
    public RectTransform joystickBackground;

    private void Start()
    {
        joystickTransform = GetComponent<RectTransform>();
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
            Vector2 localPosition = position - joystickTransform.sizeDelta / 2f;
            rotationInput = localPosition.normalized;

            // Send joystick input to the rotation controller script
            rotationController.SetRotationInput(rotationInput);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        OnDrag(eventData);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // Handle joystick release if needed
        rotationInput = Vector2.zero;

        // Send zero input to the rotation controller script to stop rotation
        rotationController.SetRotationInput(rotationInput);
    }
}
