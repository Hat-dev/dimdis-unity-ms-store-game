using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathsparrow : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Invoke("Restart",2.5f);
            Debug.Log ("died");
            rb.bodyType = RigidbodyType2D.Static;
            anim.SetTrigger("death");
        }
        else if (collision.gameObject.CompareTag("wall"))
        {
            Invoke("Restart",2.5f);
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
