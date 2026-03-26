using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class marsMove : MonoBehaviour
{
    [SerializeField] private LayerMask jumpableGround;
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 move;
    public Collider2D coll;
    public GameObject music;
    void Start()
    {   
        music = GameObject.FindWithTag("music");
    }
    private bool Grounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0, Vector2.down, .3f, jumpableGround);
    }
    void Update()
    {
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
    void FixedUpdate()
    {
        if (Input.GetKey("d") && Grounded())
        {
            rb.velocity = new Vector3(moveSpeed, moveSpeed, 0);
        }
        if (Input.GetKey("a") && Grounded())
        {
            rb.velocity = new Vector3(-moveSpeed, moveSpeed, 0);
        }
    }
}
