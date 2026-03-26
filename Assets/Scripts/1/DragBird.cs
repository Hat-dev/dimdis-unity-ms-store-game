using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DragBird : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 5;
    public Rigidbody2D rb;
    public GameObject glitchy;
    public float targetTime = 5.0f;
    public float Timer = 5.0f;
    private Animator anim;
    public Slider chargebar;
    public GameObject music;
    [SerializeField] private AudioSource dashSound;
    [SerializeField] private AudioSource slapSound;

    dotHealth dh;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        dh = glitchy.GetComponent<dotHealth>();
        music = GameObject.FindWithTag("music");
    }
    void FixedUpdate(){
        if(Input.GetKeyDown("b")) {
            Destroy(music);
        SceneManager.LoadScene("levelselect 1");
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        }
        float step = speed * Time.deltaTime;
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();
        float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotation_z-90);

        targetTime -= Time.deltaTime;
        if ((targetTime <= 0.0f)&&(Input.GetKey("space")))
        {
            targetTime = Timer;
            dashSound.Play();
            rb.velocity = transform.up*speed*10;
            Invoke("stop",0.5f);
        }
        
        chargebar.value=Timer/targetTime-1;
        if (chargebar.value<=0)
        {
            chargebar.gameObject.SetActive(false);
        }
        else 
        {
            chargebar.gameObject.SetActive(true);
        }

        if (Mathf.Approximately(rb.velocity.x,0) && glitchy.gameObject!=null)
        {
            glitchy.gameObject.tag = "Enemy";
        }
        else if (glitchy.gameObject!=null)
        {
            glitchy.gameObject.tag = "Vunerable";
        }
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        if (Input.GetKey("mouse 0"))
        {
        transform.position = Vector2.MoveTowards(transform.position, objPosition, step);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Vunerable")
        {
            dh.TakeDamage(damage);
            slapSound.Play();
            Debug.Log("Injured");
        }

    }
    void stop(){
        rb.velocity = new Vector3(0,0,0);
    }
}