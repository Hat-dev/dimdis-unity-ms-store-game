using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class leafmove : MonoBehaviour
{
    Rigidbody2D rb;
    public float movement = 0f;
    public float speed = 5f;
    public GameObject music;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        music = GameObject.FindWithTag("music");
    }
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
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
        Vector2 velocity = rb.velocity;
        velocity.x = movement*speed;
        rb.velocity = velocity;
    }
}
