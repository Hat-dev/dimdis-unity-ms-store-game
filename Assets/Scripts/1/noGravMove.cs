using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class noGravMove : MonoBehaviour
{
    [SerializeField] private float forwardForce = 17f;
    public float clockwise = 1000.0f;
    public Rigidbody2D rb;
    public GameObject music;
    [SerializeField] private AudioSource jumpSound;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        music = GameObject.FindWithTag("music");

    }

    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (Input.GetButtonDown("Jump"))
        {
            jumpSound.Play();
            rb.velocity = new Vector3(0,0,0);
            rb.AddForce (transform.up*forwardForce);
        } 
        if (Input.GetKey(KeyCode.D)) {
            transform.Rotate(0, 0, Time.deltaTime * -clockwise);
        }
        else if(Input.GetKey(KeyCode.A)) {
            transform.Rotate(0, 0, Time.deltaTime * clockwise);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Rotate(0, 0, Time.deltaTime * -clockwise);
        }
        else if(Input.GetKey(KeyCode.LeftArrow)) {
            transform.Rotate(0, 0, Time.deltaTime * clockwise);
        }
        if(Input.GetKeyDown("b")) {
        SceneManager.LoadScene("levelselect");
        Destroy(music);
        }
    }
}
