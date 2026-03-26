using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class creativebossmove : MonoBehaviour
{
    public GameObject music;
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 move;
    void Start()
    {   
        music = GameObject.FindWithTag("music");
    }
    void Update()
    {
        if(Input.GetKeyDown("b")) {
            Destroy(music);
        SceneManager.LoadScene("bosslvlselect");
        }
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + move.normalized * moveSpeed * Time.fixedDeltaTime);
    }
}
