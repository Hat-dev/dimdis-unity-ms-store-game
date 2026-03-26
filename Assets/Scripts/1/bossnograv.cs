using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bossnograv : MonoBehaviour
{
    [SerializeField] private float forwardForce = 17f;
    public float clockwise = 1000.0f;
    public Rigidbody2D rb;
    public GameObject music;

    void Start()
    {
        music = GameObject.FindWithTag("music");
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector3(0,0,0);
            rb.AddForce (transform.up*forwardForce);
        } 
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
        if(Input.GetKeyDown("b")) {
            Destroy(music);
        SceneManager.LoadScene("bosslvlselect");
        }
    }
}
