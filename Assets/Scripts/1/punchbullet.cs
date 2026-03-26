using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class punchbullet : MonoBehaviour
{
    public int damage = 5;
    public float speed = 10f;
    public Rigidbody2D rb;
    [SerializeField] 
    private float lifeTime = 2f;
    private void Awake()
    {
        Invoke("DestroySelf", lifeTime);
    }
    
    void Start()
    {
        rb.velocity = transform.right*speed;
        Physics2D.IgnoreLayerCollision(7,8,true);
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        MainHealth enemy = hitInfo.GetComponent<MainHealth>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        DestroySelf();
    }
    internal void DestroySelf()
    {
        gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
