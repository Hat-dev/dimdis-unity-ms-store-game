using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newgravmove : MonoBehaviour
{
    [SerializeField] private LayerMask jumpableGround;
    public GameObject player;
    public Rigidbody2D rb;
    private float dirX = 0f;
    public Collider2D coll;
    public GameObject music;

    [SerializeField] private float moveSpeed = 8f;
    [SerializeField] private float jumpForce = 17f;

    private void Start()
    {
        music = GameObject.FindWithTag("music");
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();
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
        SceneManager.LoadScene("levelselect 1");
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
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, 0);
        } 
        else if (Input.GetKeyDown("up") && Grounded())
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, 0);
        }
        else if (Input.GetKeyDown("w") && Grounded())
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, 0);
        }
    } 
}
