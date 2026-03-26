using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gravintro : MonoBehaviour
{
    [SerializeField] private LayerMask jumpableGround;
    public GameObject player;
    public Rigidbody2D rb;
    private float dirX = 0f;
    public Collider2D coll;
    public GameObject music;

    [SerializeField] private float moveSpeed = 8f;
    [SerializeField] private float jumpForce = 17f;

    // Reference to the JoystickController script
    private JoystickController joystickController;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();
        music = GameObject.FindWithTag("music");
        
        // Get the reference to the JoystickController script
        joystickController = FindObjectOfType<JoystickController>();
    }

    private void Update()
    {
        // Get the horizontal input from both the joystick controller and original input
        dirX = joystickController.InputDirection.x + Input.GetAxisRaw("Horizontal");

        // Move the player using the combined input
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        UpdateMovementCode();

        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private bool Grounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0, Vector2.down, .1f, jumpableGround);
    }

    private void UpdateMovementCode()
    {
        if ((joystickController.InputDirection.y > 0.5f || Input.GetButtonDown("Jump")) && Grounded())
        {
            // Jump when the joystick is moved upward or the original jump button is pressed and the player is grounded
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, 0);
        }
    }
}

