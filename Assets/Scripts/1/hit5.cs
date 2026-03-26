using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hit5 : MonoBehaviour
{
    public float health;
    public float hitdmg;
    private Rigidbody2D rb;
    public Vector3 left;
    public Vector3 right;
    private Vector3 good;
    [SerializeField] private AudioSource hitSound;
    public GameObject music;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        music = GameObject.FindWithTag("music");
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player") 
        {
            Debug.Log("hit");
            health -= hitdmg;
            hitSound.Play();
            if (rb.transform.position==left){
            rb.transform.position=right;
            }
            else if (rb.transform.position==right){
            rb.transform.position=left;
            }
        }
    }
    void Update()
    {
        if(health<=0)
        {
            Destroy(music);
            completion3.twentycomplete = true;
            Debug.Log("tru");
            SceneManager.LoadScene("bosslvlselect");
        }
    }
}
