using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SlitherMove : MonoBehaviour
{
    public float clockwise = 1000.0f;
    public Rigidbody2D rb;
    public float speed = 10f;
    public GameObject music;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        music = GameObject.FindWithTag("music");
    }

    void FixedUpdate()
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
        rb.velocity = transform.up * speed;
 
        if (Input.GetKey(KeyCode.D)) {
            transform.Rotate(0, 0, Time.deltaTime * -clockwise);
        }
        else if(Input.GetKey(KeyCode.A)) {
            transform.Rotate(0, 0, Time.deltaTime * clockwise);
        }
        if (Input.GetKey(KeyCode.Mouse1)) {
            transform.Rotate(0, 0, Time.deltaTime * -clockwise);
        }
        else if(Input.GetKey(KeyCode.Mouse0)) {
            transform.Rotate(0, 0, Time.deltaTime * clockwise);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Rotate(0, 0, Time.deltaTime * -clockwise);
        }
        else if(Input.GetKey(KeyCode.LeftArrow)) {
            transform.Rotate(0, 0, Time.deltaTime * clockwise);
        }
    }
}
