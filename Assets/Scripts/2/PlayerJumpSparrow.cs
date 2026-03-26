using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerjumpsparrow : MonoBehaviour
{
    [SerializeField] private LayerMask jumpableGround;
    public GameObject player;
    public Rigidbody2D rb;
    private float dirX = 0f;
    public Collider2D coll;
    public GameObject music;

    [SerializeField] private float moveSpeed = 8f;
    [SerializeField] private float jumpForce = 17f;
    public float cutJumpHeight;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();
        music = GameObject.FindWithTag("music");
    }
    private void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);
        UpdateMovementCode();
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if(Input.GetKeyDown("b")) 
        {
            Destroy(music);
        SceneManager.LoadScene("levelselect");
        }
    }
    private bool Grounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0, Vector2.down, .1f, jumpableGround);
    }
    private void UpdateMovementCode()
    {
        if (Input.GetButtonDown("Jump") && Grounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        if (Input.GetButtonUp("Jump") && (rb.velocity.y>0f))
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y*cutJumpHeight);
        }  
        


        if (Input.GetKeyDown("up") && Grounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        if (Input.GetKeyUp("up") && (rb.velocity.y>0f))
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y*cutJumpHeight);
        }



        if (Input.GetKeyDown("w") && Grounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        if (Input.GetKeyUp("w") && (rb.velocity.y>0f))
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y*cutJumpHeight);
        }
    } 
}
