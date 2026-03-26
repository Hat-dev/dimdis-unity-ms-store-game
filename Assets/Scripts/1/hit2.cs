using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hit2 : MonoBehaviour
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
        music = GameObject.FindWithTag("music");
        rb = GetComponent<Rigidbody2D>();
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
            else
            {
                rb.transform.position=left;
            }
        }
    }
    void Update()
    {
        if(health<=0)
        {
            Destroy(music);
            completion3.seventeencomplete = true;
            Debug.Log("tru");
            SceneManager.LoadScene("bosslvlselect");
        }
    }
}
