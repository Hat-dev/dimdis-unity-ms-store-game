using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class fishWASD : MonoBehaviour
{
    public float thrust = 15.0f;
    public Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (Input.GetKey("w"))
        {
            rb.velocity = new Vector3(0,0,0);
            rb.AddForce (Vector2.up * thrust, ForceMode2D.Impulse);
        } 
        else if (Input.GetKey("a"))
        {
            rb.velocity = new Vector3(0,0,0);
            rb.AddForce (Vector2.left * thrust, ForceMode2D.Impulse);
        }
        else if (Input.GetKey("d"))
        {
            rb.velocity = new Vector3(0,0,0);
            rb.AddForce (Vector2.right * thrust, ForceMode2D.Impulse);
        }
        else if (Input.GetKey("s"))
        {
            rb.velocity = new Vector3(0,0,0);
            rb.AddForce (Vector2.down * thrust, ForceMode2D.Impulse);
        }
    }
}