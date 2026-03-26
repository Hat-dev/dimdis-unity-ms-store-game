using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickController : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    private RectTransform joystickTransform;
    public float joystickRadius;
    private Vector2 inputDirection;
    public RectTransform joystickBackground;

    // Add a public property to access inputDirection
    public Vector2 InputDirection => inputDirection;

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

            // Calculate input direction based on the joystick position
            float x = clampedPosition.x / joystickRadius;
            float y = clampedPosition.y / joystickRadius;
            inputDirection = new Vector2(x, y);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        OnDrag(eventData);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        inputDirection = Vector2.zero;

        // Stop the player character's movement when the joystick is released
        // You can customize your character stopping code here
        // Example: StopCharacterMovement();
    }
}

