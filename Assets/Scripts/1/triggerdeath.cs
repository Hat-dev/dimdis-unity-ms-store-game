using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerdeath : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    public GameObject music;
    [SerializeField] private AudioSource deadSound;
    private void Update(){
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if(Input.GetKeyDown("b")) 
        {
            Destroy(music);
        SceneManager.LoadScene("levelselect");
        }
    }
    private void Start()
    {
        music = GameObject.FindWithTag("music");
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            deadSound.Play();
            Debug.Log ("died");
            rb.bodyType = RigidbodyType2D.Static;
            anim.SetTrigger("death");
        }

    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
