using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AtariDouble : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 move;
    public GameObject music;
    void Start()
    {   
        music = GameObject.FindWithTag("music");
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
        SceneManager.LoadScene("levelselect");
        }
        move.x = Input.GetAxisRaw("Horizontal");
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + move.normalized * moveSpeed * Time.fixedDeltaTime);
        
    }
}
