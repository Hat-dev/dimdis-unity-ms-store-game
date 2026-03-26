using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class newcmove : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public GameObject music;
    
    // Joystick variables
    private Vector2 joystickInput;
    private bool isJoystickActive = false;

    void Start()
    {   
        music = GameObject.FindWithTag("music");
    }

    void Update()
    {
        if (Input.GetKeyDown("b")) 
        {
            Destroy(music);
            SceneManager.LoadScene("levelselect");
        }

        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        // Check if the joystick handle is active (dragging or being pressed)
        isJoystickActive = joystickInput.magnitude > 0.1f;
    }

    void FixedUpdate()
    {
        // Handle character movement based on joystick input or keyboard input
        if (isJoystickActive)
        {
            rb.MovePosition(rb.position + joystickInput.normalized * moveSpeed * Time.fixedDeltaTime);
        }
        else
        {
            Vector2 keyboardInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            rb.MovePosition(rb.position + keyboardInput.normalized * moveSpeed * Time.fixedDeltaTime);
        }
    }

    // This method will be called by the JoystickController script
    public void SetJoystickInput(Vector2 input)
    {
        joystickInput = input;
    }
}
