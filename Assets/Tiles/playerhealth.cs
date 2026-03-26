using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerhealth : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    public float health = 100f;
    public void TookDamage(float damage)
    {
        Debug.Log("hit");
        health -= damage;
        if (health <= 0)
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
