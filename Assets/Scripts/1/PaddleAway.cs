using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PaddleAway : MonoBehaviour
{
    public float thrust = 15.0f;
    public Rigidbody2D rb;
    public GameObject music;
    [SerializeField] private AudioSource swingSound;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        music = GameObject.FindWithTag("music");
    }

    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();
        float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg-90;
        transform.rotation = Quaternion.Euler(0f, 0f, rotation_z);
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if(Input.GetKeyDown("b")) 
        {
        Destroy(music);
        SceneManager.LoadScene("levelselect");
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            swingSound.Play();
            rb.velocity = new Vector3(0,0,0);
            rb.AddForce (transform.up*50*thrust);
            rb.AddForce (transform.right*50*thrust);
        } 
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            swingSound.Play();
            rb.velocity = new Vector3(0,0,0);
            rb.AddForce (transform.up*50*thrust);
            rb.AddForce (transform.right*-50*thrust);
        } 
    }
}
